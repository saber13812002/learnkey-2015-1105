function openSection (id){
		$("#course-item-desc-"+id).slideToggle(500);
}

function openLiveZillaWin(){
    myWindow = window.open('http://mesbahsoft.com/chatserver/chat.php?acid=4305f', '', 'width=450,height=500');
	myWindow.focus();	
}

$(document).ready(function() {


  $(".course-box table a").css({'color': '#000', 'text-shadow':'#fff 0px 1px 1px'});

  $(".index-part3 .right").mouseover(function(){
        $(".course-box table").css({'color': '#fff', 'text-shadow':'#000 0px 1px 0px'});
        $(".course-box table a").css({'color': '#fff', 'text-shadow':'#000 0px 1px 0px'});
  });

  $(".index-part3 .right").mouseout(function(){
        $(".course-box table").css({'color': '#000', 'text-shadow':'#fff 0px 1px 1px'});
        $(".course-box table a").css({'color': '#000', 'text-shadow':'#fff 0px 1px 1px'});
  });

  $(".teacher-box").mouseover(function(){

      $(this).css({"background":'#2D2D2D', 'color': '#fff'});
      $("#box-tch-"+ $(this).attr("data") ).show();
      $("#box-tc-"+ $(this).attr("data") ).hide();

  });

  $(".teacher-box").mouseout(function(){

      $(this).css({"background":'#002F66', 'color': '#fff'});
      $("#box-tch-"+ $(this).attr("data") ).hide();
      $("#box-tc-"+ $(this).attr("data") ).show();

  });

	$(".call-me").mouseover(function() {
		$( "#call-pic" ).effect( "shake", {times:1},{distance:5} );
	});

});


