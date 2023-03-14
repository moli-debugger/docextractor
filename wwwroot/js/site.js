// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let lastFocus;
let currentFocus = document.activeElement;

function setCurrentFocusAsLastFocus() {
  currentFocus = document.activeElement;
  lastFocus = currentFocus;
}

function backToLastFocus() {

  lastFocus.focus();
  document.getElementById(lastFocus.id).focus();
}
$("p,li").click(function () {
  var text=$(this).text();
  backToLastFocus()
  $(":focus").val(text)
})

var table=$(".wrapper").find("table").text()
console.log(table)
$("#createTable").click(function () {
  $(".table_wrapper").toggle();
})



