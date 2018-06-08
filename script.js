$(document).ready(function() {
  $.ajax({
      type: "GET",
      dataType: "json",
      url: "http://localhost:5000/aplicacao/pais"
  }).then(function(data) {
      alert(data);
  });
});