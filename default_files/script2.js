/**
 * @author Saman
 */

$(function(){

  $('#slimScrollBoxCourse').slimScroll({
  		railVisible: true,
      	railOpacity: 0.2,
      	height: '150px',
  });
  
});

$(document).ready(function() {
	
	$(".call-me").click(function(){
		Recaptcha.reload();
       	$("#success-callme-label").hide();
       	$("#unsuccess-callme-label").hide();
	});
	
    $("#callmenumber").keydown(function(event) {
        // Allow: backspace, delete, tab, escape, and enter
        if ( event.keyCode == 46 || event.keyCode == 8 || event.keyCode == 9 || event.keyCode == 27 || event.keyCode == 13 || 
             // Allow: Ctrl+A
            (event.keyCode == 65 && event.ctrlKey === true) || 
             // Allow: home, end, left, right
            (event.keyCode >= 35 && event.keyCode <= 39)) {
                 // let it happen, don't do anything
                 return;
        }
        else {
            // Ensure that it is a number and stop the keypress
            if (event.shiftKey || (event.keyCode < 48 || event.keyCode > 57) && (event.keyCode < 96 || event.keyCode > 105 )) {
                event.preventDefault(); 
            }   
        }
    });
});

// variable to hold request
var request;
// bind to the submit event of our form
$("#callmeform").submit(function(event){
    // abort any pending request
    if (request) {
        request.abort();
    }
    // setup some local variables
    var $form = $(this);
    // let's select and cache all the fields
    var $inputs = $form.find("input, select, button, textarea, number");
    // serialize the data in the form
    var serializedData = $form.serialize();

    // let's disable the inputs for the duration of the ajax request
    $inputs.prop("disabled", true);

    // fire off the request to /form.php
    request = $.ajax({
        url: "save.php",
        type: "post",
        data: serializedData
    });

    // callback handler that will be called on success
    request.done(function (response, textStatus, jqXHR){
        // log a message to the console
/*        console.log(response);
        console.log("Hooray, it worked!");*/
//       alert(response);
       if ( response === "1" ){
       	$("#success-callme-label").hide();
       	$("#unsuccess-callme-label").hide();

       	$("#success-callme-label").show();
       }

       if ( response === "0" ){
       	$("#success-callme-label").hide();
       	$("#unsuccess-callme-label").hide();

       	$("#unsuccess-callme-label").show();
       }

    });

    // callback handler that will be called on failure
    request.fail(function (jqXHR, textStatus, errorThrown){
//       alert(response);
        // log the error to the console
       	$("#success-callme-label").hide();
       	$("#unsuccess-callme-label").hide();

       	$("#unsuccess-callme-label").show();
       	
    });

    // callback handler that will be called regardless
    // if the request failed or succeeded
    request.always(function () {
        // reenable the inputs
        $inputs.prop("disabled", false);
    });

    // prevent default posting of form
    event.preventDefault();
});	
	