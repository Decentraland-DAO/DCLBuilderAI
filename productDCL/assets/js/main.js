window.history.pushState('tool', 'Tool', '/tool');

const generateProTips = [
  "Pro Tip: If you are not satisfied with the results, you can keep clicking \n on 'Generate' again to regenerate the response until you get what you're looking for.",
  "Pro Tip: Use tick mark to indicate that the scripts are correct.\nBy using your feedback as training data, we aim to create\nthe single largest fine-tuned model for Decentraland.",
  "Pro Tip: You can ask ScripterAI to add comments to the code by appending 'add comments to code' to your request."
];

// initializing the code mirror
var editor = CodeMirror.fromTextArea(document.getElementById("editor"), {
    mode: "lua",
    theme: "dracula",
    lineNumbers: true,
    autoCloseTags: true
});
editor.setSize("100%", "450");

// Functions of Editor
$(document).ready(function () {

    $(function () {
      $('[data-toggle="tooltip"]').tooltip()
    })

    // changing the theme
    $('#changeTheme').on('change', function () {
      var theme = $(this).val()
      editor.setOption('theme', theme)
    })

    let randomIndex = Math.floor(Math.random() * 3);
    document.getElementById('biotext').innerHTML = generateProTips[randomIndex];

    // textarea lenght counting
    $('#elemprompt').on('keyup', ()=> {
        var txtAreaVal = $(this).val()
        txtAreaVal = document.getElementById('elemprompt').value
        $('#txtlenght').html(txtAreaVal.length)
        // console.log()
    })

    // clearing the codemirror code
    var codemirrorEditor = $('#editor').nextAll('.CodeMirror')[0].CodeMirror;

    $("#hide").click(function () {
        codemirrorEditor.getDoc().setValue("");
    });

    // copy to clipboard code
    $('#copytoclip').on('click', function () {
        $(this).html('<span class="mdi delet-icon mdi-check edit1"></span>Copied');
        navigator.clipboard.writeText(codemirrorEditor.getValue());

        setTimeout(() => {
            $('#copytoclip').html('<span class="mdi delet-icon mdi-content-copy delet1"></span>Copy');
        }, 1000);
    })

    // downloading the file
    $('#downloadCode').on('click', function () {

       var a = window.document.createElement('a');
       a.href = window.URL.createObjectURL(new Blob([codemirrorEditor.getValue()], { type: 'text/plain' }));
       a.download = 'script.lua';

       document.body.appendChild(a);
       a.click();
       document.body.removeChild(a);
   })

    // sweet alert (success)
    $('#sweetsuccess').on('click', function () {

        let editorval = editor.getValue().trim();
        let promptval = $('#elemprompt').val().trim();

        if(editorval.length < 10 || promptval.length < 4) {
          Swal.fire({
              title: "Success",
              text: "We have recorded your feedback. Thank you!",
              icon: "success",
              button: "OK",
          });
          return;
        }

        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/addToTrainingSet', true);
        xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
        xhr.onload = function () {
          Swal.fire({
              title: "Success",
              text: "We have recorded your feedback. Thank you!",
              icon: "success",
              button: "OK",
          });
        };
        xhr.send('prompt1='+promptval+'&editor1='+editorval);
    })

    // sweet alert (success)
    $('#sweetdanger').on('click', function () {
        Swal.fire({
            title: "Incorrect Code Generated",
            text: "We have recorded your feedback. Thank you!",
            icon: "warning",
            button: "OK",
        });
    })


    const generateRandomMessages = [
      "-- Generating code, usually takes 3-4 seconds, thanks for your patience!\n",
      "-- Generating code, usually takes 3-4 seconds, so grab a snack and wait!\n",
      "-- Generating code is like waiting for the perfect avocado, it usually\n-- takes 3-4 seconds, but patience is a virtue!\n",
      "-- Generating code... it's like watching paint dry, but with a few more\n-- seconds! Thanks for your patience!\n",
      "-- Generating code, usually takes 3-4 seconds...or you could just buy a\n-- magic wand and get it done instantly!\n",
      "-- Generating code, usually takes 3-4 seconds, so grab a snack and relax!\n",
      "-- Generating code, usually takes 3-4 seconds, at least it's not as long as\n-- a century! Thanks for your patience\n"
    ];


    // getting the value from the textarea and setting in the editor
    $('#generateCode').on('click', function () {

        // getting the value
        let textval = $('#elemprompt').val().trim();

        if(textval.length < 6) {
              Swal.fire({
                  title: "Prompt is too short",
                  text: "Your prompt is too short for ScripterAI to work.",
                  icon: "warning",
                  button: "OK",
              });
          return;
        }

        let randomNum = Math.floor(Math.random() * 3);
        if(randomNum == 2) {
          if(!textval.toLowerCase().includes("decentraland")) {
            textval += " in decentraland";
          }
        }

        let randomIndex = Math.floor(Math.random() * 7);
        editor.setValue(generateRandomMessages[randomIndex]);

        if (textval === 'create a part') {
          setTimeout(function() {
            editor.setValue(Ex1)
          }, 2000);
          return;
        }

        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/generate', true);
        xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
        xhr.onload = function () {
          var data = JSON.parse(this.responseText).replaceAll("/*", "--").replaceAll("*/", "").replaceAll(" wait(", " task.wait(").trimStart() + "\n";
          editor.setValue(data);
          document.getElementById('txtlenghtEditor').innerHTML = data.length;
          //populateSuggestions(textval, data);
        };
        var id = document.getElementById("id");
        xhr.send('prompt1='+textval+'&id='+id.value);
    })

    $('#generateFromEditorCode').on('click', function () {

        // getting the value
        let textval = editor.getValue().trim();
        let promptval = $('#elemprompt').val().trim();

        if(promptval.length < 6) {
              Swal.fire({
                  title: "Prompt is too short",
                  text: "Your prompt is too short for ScripterAI to work.",
                  icon: "warning",
                  button: "OK",
              });
          return;
        }

        if(textval.length > 1000) {
              Swal.fire({
                  title: "1000 character limit exceeded",
                  text: "You have more than 1000 characters in the editor.",
                  icon: "warning",
                  button: "OK",
              });
          return;
        }

        let randomIndex = Math.floor(Math.random() * 7);
        editor.setValue(generateRandomMessages[randomIndex]);

        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/generateFromEditor', true);
        xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
        xhr.onload = function () {
          var data = JSON.parse(this.responseText).replaceAll("/*", "--").replaceAll("*/", "").trimStart() + "\n";
          editor.setValue(data);
          document.getElementById('txtlenghtEditor').innerHTML = data.length;
        };
        var id1 = document.getElementById("id");
        xhr.send('prompt1='+promptval+'&lastText1='+textval+'&id='+id1.value);
    })

    $('#generateFromGPT').on('click', function () {

      // getting the value
      let textval = $('#elemprompt').val().trim() + " in Decentraland";
      if(textval.length < 15) {
            Swal.fire({
                title: "Prompt is too short",
                text: "Your prompt is too short for ScripterAI to work.",
                icon: "warning",
                button: "OK",
            });
        return;
      }

      let randomIndex = Math.floor(Math.random() * 7);
      editor.setValue(generateRandomMessages[randomIndex]);

      if (Math.floor(Math.random() * 2) === 1) {
        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/generate', true);
        xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
        xhr.onload = function () {
          var data = JSON.parse(this.responseText).replaceAll("/*", "--").replaceAll("*/", "").trimStart() + "\n";
          editor.setValue(data);
          document.getElementById('txtlenghtEditor').innerHTML = data.length;
        };
        xhr.send('prompt1='+textval);
      } else {
        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/generate', true);
        xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
        xhr.onload = function () {
          var data = JSON.parse(this.responseText).replaceAll("/*", "--").replaceAll("*/", "").trimStart() + "\n";
          editor.setValue(data);
        };
        var id2 = document.getElementById("id");
        xhr.send('prompt1='+textval+'&id='+id2.value);
      }
    })


});

function showWarningBeforePostDeletion(userId) {
  Swal.fire({
    title: '<strong>Warning</strong>',
              html: 'Your subscription to ScripterAI will end.<br> Are you sure?',
              icon: 'warning',
              showCancelButton: true,
              confirmButtonColor: "#DD6B55",
              confirmButtonText: "Yes, I'm sure!",
  }).then((result) => {
        if (result.isConfirmed) {
            var xhr = new XMLHttpRequest();
            xhr.open('POST', '/cancelSubcription', true);
            xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
            xhr.onload = function () {
               window.location = "/";
            };
            xhr.send('id='+userId);
        }
    });
};

function populateSuggestions(textval, data) {
  // make suggestion request
}

function showAlreadyCancelledSubscriptionText() {
  Swal.fire({
      title: "Success",
      text: "Your subscription has already been cancelled! You will no longer be charged.",
      icon: "success",
      button: "OK",
  });
}
