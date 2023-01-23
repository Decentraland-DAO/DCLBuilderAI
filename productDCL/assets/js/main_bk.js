// creating codeMirror Instance 
let editorsArr = ['editor001'];
let themeName = 'dracula';
const MaxCharacter = 5000;

var editor1 = []
var lu = 1;
var tmplu = scrptlu = 1 ;


// initializing the code mirror
var editor = CodeMirror.fromTextArea(document.getElementById('editor001'), {
  mode: 'lua',
  theme: 'dracula',
  lineNumbers: true,
  autoCloseTags: true,
  maxLenght: MaxCharacter,
})
editor.setSize('100%', '450')

editor1 = [editor]


function createEditor() {
  var d = new Date();
  var time = d.getTime();
  var rand = Math.random() * 100;

  rand = Math.floor(rand + time);


  let editorhtml = `
    <div class="tab-pane TabEditor fade" id="tab${rand}" value="${lu}">
    <textarea id="editor${rand}">print("Script ${++scrptlu}")</textarea>
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
    mode: 'lua',
    theme: themeName,
    lineNumbers: true,
    autoRefresh: true,
    autoCloseTags: true,
    maxLenght: MaxCharacter,
    autofocus: true,
  })

lu++

  $(`.CodeMirror-sizer`).addClass('customMirror');
  $(`#editor${rand}`).data('CodeMirrorInstance', editor);

  editor1.push(editor)

}


/* max-length */
window.CMUtils = window.CMUtils || {};

CMUtils.enforceMaxLength = function(cm, change) {
  var maxLength = cm.getOption("maxLength");
  if (maxLength && change.update) {
      var str = change.text.join("\n");
      var delta = str.length-(cm.indexFromPos(change.to) - cm.indexFromPos(change.from));
      if (delta <= 0) { return true; }
      delta = cm.getValue().length+delta-maxLength;
      if (delta > 0) {
          str = str.substr(0, str.length-delta);
          change.update(change.from, change.to, str.split("\n"));
      }
  }
  return true;
}

editor.setOption("maxLength", MaxCharacter);
editor.on("beforeChange", CMUtils.enforceMaxLength);

function checkTextCharacters(ch) {
  var x = '';
  for(var i = 0; i < ch.length; i++) {
    if(i < MaxCharacter) {
      x += ch[i];
    }
  }
  return x;
}

function countTextCharacters() {
  var x = editor.getValue()  
  return x.length;
}

editor.on('keyup', ()=> {
  var x = countTextCharacters();
  $('#editorMaxVal').html(x)
})

var x = countTextCharacters();
$('#editorMaxVal').html(x)

/* checking max-length ends here */


// Functions of Editor
$(document).ready(function () {

  $(function () {
    $('[data-toggle="tooltip"]').tooltip()
  })

  var codeInstance = '#editor001';
  // var codemirrorEditor = $('#editor001').nextAll('.CodeMirror')[0].CodeMirror
  
  $('#editor001').data('CodeMirrorInstance', editor);
  var codemirrorEditor = $('#editor001').data('CodeMirrorInstance');

  $(document).on('click', '.openTab', function() {
    // console.log(editor1)
    codeMrrInstance = parseInt($('#appendeditor .tab-pane.active').attr('value'));

    setTimeout(() => {
      
      codeMrrInstance = $('#appendeditor .tab-pane.active .inp').val();
      console.log(codeMrrInstance)
      codemirrorEditor = editor1[codeMrrInstance]
    }, 500);

    console.log()
  })

  // changing the theme
  $('#changeTheme').on('change', function () {
    themeName = $(this).val()
    for(i in editor1) {
      console.log(i)
      editor1[i].setOption('theme', themeName)
    }
  })
  $('#changeTheme').select2()

  // textarea lenght counting
  $('#elemprompt').on('keyup', () => {
    var txtAreaVal = $(this).val()
    txtAreaVal = document.getElementById('elemprompt').value
    $('#txtlenght').html(txtAreaVal.length)
  })

  // clearing the codemirror code
  // var codemirrorEditor = $('#editor001').nextAll('.CodeMirror')[0].CodeMirror

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
    swal({
      title: 'Good job!',
      text: 'Here is success message',
      icon: 'success',
      button: 'OK!',
    })
  })

  // sweet alert (success)
  $('#sweetdanger').on('click', function () {
    swal({
      title: 'Danger Message',
      text: 'You clicked the button!',
      icon: 'warning',
      button: 'OK!',
    })
  })

  // setting the value of editor
  let Ex1 = `other = require "other"
other.hi()
    
for i = 1, #arg do
    local str = string.format("Arg %i is %q", i, arg[i])
    print(str)
end`

  let Ex2 = `--[[
this is Example 2
]]`

  let Ex3 = `print("Hello World")`

  $('#Ex1').on('click', function () {
  
    
    Ex1 = checkTextCharacters(Ex1);
    codemirrorEditor.setValue(Ex1)

    // counting the value of characters
    var x = countTextCharacters();
    $('#editorMaxVal').html(x)
  })

  $('#Ex2').on('click', function () {
    Ex2 = checkTextCharacters(Ex2);
    codemirrorEditor.setValue(Ex2)

    // counting the value of characters
    var x = countTextCharacters();
    $('#editorMaxVal').html(x)
  })

  $('#Ex3').on('click', function () {
    Ex3 = checkTextCharacters(Ex3);
    codemirrorEditor.setValue(Ex3)

    // counting the value of characters
    var x = countTextCharacters();
    $('#editorMaxVal').html(x)
  })

  // getting the value from the textarea and setting in the editor
  $('#generateCode').on('click', function () {
    // getting the value
    let textval = $('#elemprompt').val()
    codemirrorEditor.setValue(textval)
  })
})
