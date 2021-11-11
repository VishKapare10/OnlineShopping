/* var onInitialize=function(){
    console.log("On load event is occured");
    //Attach click event handler to both button
    var btn1=document.getElementById("btnHide");
    var btn2=document.getElementById("btnUnhide");
    btn1.addEventListener("click",onButtonHideClick);
    btn2.addEventListener("click",onButtonUnhideClick);
}
 */
$(document).ready(function(){
        //Event Binding
        $("#btnHide").click(onButtonHideClick);
        $("#btnUnhide").click(onButtonUnhideClick);    
});

var onButtonHideClick=function(){
        $("#course").hide();
}

var onButtonUnhideClick=function(){

        $("#course").show();
        $("#fname").val("This is Vishwambhar Kapare");
}

