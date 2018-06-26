var apiRootUrl = 'http://voteapi.empower2018.us';

function options(){
  $('#options').click(function(){
    $.get(apiRootUrl + '/apis', function(data){
      var optionData = '';
      for (var i=0; i < data.length; i++){
        optionData += "<p>API: " +data [i].name + " // " + "ID: " + data[i]._id + "</p>";
      }
      $('#options-container').html(optionData);
    });
});
}

function results(){
  $('#results').click(function(data){
    $.get(apiRootUrl + '/tally', function(data){
      var optionData = '';
      for (var i=0; i < data.length; i++){
        optionData += "<p>API: " + data[i].api_name + " //" + " Vote Count: "+data[i].vote_count + "</p>"

      }
      $('#options-container').html(optionData);
    });
});
}

function vote(){
  $('#vote').click(function(){
        $.post(apiRootUrl + '/itsherbvasquez/vote',
          {"api_name":$('#textbox').val()},
          function(data){
            console.log(data);
          });
        });
}

function myvote(){
  $('#myvote').click(function(data){
    $.get(apiRootUrl + '/itsherbvasquez/vote',function(data){
      $('#options-container').html('You voted for: '  + data.message.api_name );
    });
  });
}

function reset(){
  $('#reset').click(function(){
    var deleteVote = {
      url: apiRootUrl + '/itsherbvasquez/vote',
      type: 'DELETE'
    };
    $.ajax(deleteVote);
  });
};
