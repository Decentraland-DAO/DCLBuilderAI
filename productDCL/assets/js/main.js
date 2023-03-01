window.CMUtils = window.CMUtils || {};

CMUtils.enforceMaxLength = function (cm, change) {
  var maxLength = cm.getOption("maxLength");
  if (maxLength && change.update) {
    var str = change.text.join("\n");
    var delta = str.length - (cm.indexFromPos(change.to) - cm.indexFromPos(change.from));
    if (delta <= 0) { return true; }
    delta = cm.getValue().length + delta - maxLength;
    if (delta > 0) {
      str = str.substr(0, str.length - delta);
      change.update(change.from, change.to, str.split("\n"));
    }
  }
  return true;
}

// setting no.of characters left for prompts
function setElemPrompt(prompt, val) {
  var txtAreaVal = $(prompt).val()
  $(val).html(txtAreaVal.length)
}

// creating codeMirror Instance
let editorsArr = ['editor001'];
let themeName = 'idea';
const MaxCharacter = 5000;

var editorArray = []
var lu = 1;
var tmplu = scrptlu = 1;

// initializing the code mirror
var editor = CodeMirror.fromTextArea(document.getElementById('editor001'), {
  mode: 'text/typescript',
  theme: themeName,
  lineNumbers: true,
  autoRefresh: true,
  matchBrackets: true,
  autoCloseTags: true,
  maxLenght: MaxCharacter,
  autofocus: true,
})
editor.setSize('100%', '450')

editor.setOption("maxLength", MaxCharacter);
editor.on("beforeChange", CMUtils.enforceMaxLength);

editor.on('change', editor => {
  let x = editor.getValue();
  $('#editorMaxVal').html(x.length)
})

$('#editor001').data('CodeMirrorInstance', editor);
var codemirrorEditor = $('#editor001').data('CodeMirrorInstance');

editorArray = [editor]

// limit the editor instances
const maxEditors = 4;

for (var i = 1; i < maxEditors; i++) {

  var d = new Date();
  var time = d.getTime();
  var rand = Math.random() * 100;
  rand = Math.floor(rand + time);

  let editorhtml = `
    <div class="tab-pane TabEditor fade" id="tab${rand}" value="${lu}">
    <textarea id="editor${rand}">/** This is editor ${++scrptlu} */
var global_var = 10
</textarea>
      <input type="hidden" value="${lu}" class="inp">
    </div>
  `;
  let tabhtml = `
    <li class="nav-item">
      <a class="nav-link openTab" data-toggle="pill" value="tab${rand}" href="#tab${rand}">Script ${++tmplu}</a>
    </li>
  `;
  $('#appendeditor').append(editorhtml)
  $('#tabappendedi').append(tabhtml)

  // initializing the code mirror
  editor = CodeMirror.fromTextArea(document.getElementById(`editor${rand}`), {
    mode: 'text/typescript',
    theme: themeName,
    lineNumbers: true,
    autoRefresh: true,
    matchBrackets: true,
    autoCloseTags: true,
    maxLenght: MaxCharacter,
    autofocus: true,
  })

  editor.setSize('100%', '450')

  editor.on('change', editor => {
    let x = editor.getValue();
    $('#editorMaxVal').html(x.length)
  })

  lu++

  $(`.CodeMirror-sizer`).addClass('customMirror');
  $(`#editor${rand}`).data('CodeMirrorInstance', editor);
  editor.setOption("maxLength", MaxCharacter);
  editor.on("beforeChange", CMUtils.enforceMaxLength);

  editorArray.push(editor)
  // codemirrorEditor = editor

  let x = editor.getValue();
  $('#editorMaxVal').html(x.length)
}


/* opening the specific tab based on index*/
let defaultIndex = 1;
$.each($('.openTab'), function (index, val) {
  $(this).removeClass('active')
})
$.each($('.TabEditor'), function (index, val) {
  $(this).removeClass('active')
  $(this).addClass('fade')
})
let ttb = document.getElementsByClassName('TabEditor')[defaultIndex];
ttb.classList.add('active');
ttb.classList.remove('fade');
document.getElementsByClassName('openTab')[defaultIndex].classList.add('active');
codemirrorEditor = editorArray[defaultIndex]


/* max-length */
function checkTextCharacters(ch) {
  var x = '';
  for (var i = 0; i < ch.length; i++) {
    if (i < MaxCharacter) {
      x += ch[i];
    }
  }
  return x;
}
/* setting editor max lenght etc */

function countTextCharacters(ed) {
  var x = editor.getValue()
  return x.length;
}
function getSetNums(ed) {
  var x = countTextCharacters(ed);
  $('#editorMaxVal').html(x)
}
getSetNums(editor);

editor.on('keyup', () => {
  getSetNums(editor)
})
/* checking max-length ends here */

// Functions of Editor
$(document).ready(function () {

  $(function () {
    $('[data-toggle="tooltip"]').tooltip()
  })

  // var codemirrorEditor = $('#editor001').nextAll('.CodeMirror')[0].CodeMirror

  $(document).on('click', '.openTab', function () {

    setTimeout(() => {
      codeMrrInstance = $('#appendeditor .tab-pane.active .inp').val();

      codemirrorEditor = editorArray[codeMrrInstance]

      let y = editorArray[codeMrrInstance].getValue()
      $('#editorMaxVal').html(y.length)
    }, 400);
  })

  codemirrorEditor.on('keyup', () => {
    let x = codemirrorEditor.getValue()
    $('#editorMaxVal').html(x.length)
  })

  // changing the theme
  $('#changeTheme').on('change', function () {
    themeName = $(this).val()
    for (i in editorArray) {
      editorArray[i].setOption('theme', themeName)
    }
  })
  $('#changeTheme').select2()

  $('#hide').click(function () {
    codemirrorEditor.getDoc().setValue('')
  })

  // copy to clipboard code
  $('#copytoclip').on('click', function () {
    $(this).html('<span class="mdi delet-icon mdi-check edit1"></span>Copied')
    navigator.clipboard.writeText(codemirrorEditor.getValue())

    setTimeout(() => {
      $('#copytoclip').html(
        '<span class="mdi delet-icon mdi-content-copy delet1"></span>Copy',
      )
    }, 1000)
  })

  // downloading the file
  $('#downloadCode').on('click', function () {
    swal('Enter File Name here:', {
      content: 'input',
      buttons: {
        cancel: 'Cancel!',
        download: true,
      },
    }).then((value) => {
      switch (value) {
        case 'download':
          var x = $('.swal-content__input').val()
          x = x.trim()
          if (x == '') {
            swal('File Name Cannot be Empty')
          } else {
            var a = window.document.createElement('a')
            a.href = window.URL.createObjectURL(
              new Blob([codemirrorEditor.getValue()], { type: 'text/plain' }),
            )
            a.download = x + '.txt'
            document.body.appendChild(a)
            a.click()
            document.body.removeChild(a)
          }
          break
      }
    })
  })

  // sweet alert (success)
  $('#sweetsuccess').on('click', function () {
    Swal.fire({
        title: "Success",
        text: "We have recorded your feedback. Thank you!",
        icon: "success",
        button: "OK",
    });

    let editorval = editor.getValue().trim();
    let promptval = $('#elemprompt').val().trim();

    var xhr = new XMLHttpRequest();
    xhr.open('POST', '/addToTrainingSet', true);
    xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
    xhr.onload = function () {
        // record response
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

  $('#generateCode').on('click', function () {

      let textval = $('#elemprompt').val().trim();
      if(textval.length < 4) {
              Swal.fire({
                  title: "Prompt is too short",
                  text: "Your prompt is too short for DCLBuilderAI to work.",
                  icon: "warning",
                  button: "OK",
              });
          return;
      }

     editorArray[0].setValue("Generating SDK7 Code using DCLBuilderAI...");

     var xhr = new XMLHttpRequest();
     xhr.open('POST', '/generate', true);
     xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
     xhr.onload = function () {
       var data = JSON.parse(this.responseText).trimStart() + "\n";
       editorArray[0].setValue(data);
     };
     xhr.send('prompt1='+textval);
  })

})
