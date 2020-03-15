$(document).ready(function(){
	function count(name){
                alert($('#'+name).size());
            }
            $(document).ready(function(){
                $("#action").draggable();
                $("#action").resizable();
                $("#action").mouseover(function(){
                    $("#action").css("cursor","move");
                });
            });

	var vrijednost=0;
            $("#novi").click(function(){
                ++vrijednost;
                var identifikacija="action"+vrijednost;
                var stepen=15;
                var dv = document.createElement("div");
                dv.style.border="1px solid black";
                dv.style.height="100px";
                dv.style.transform="rotate(0deg)"; 
                dv.style.width="100px";
                dv.id="action"+(vrijednost);
                dv.ondblclick="changeColor("+action+vrijednost+")";
                dv.title="Double click for changing the background color"
                dv.style.position="absolute";
                document.body.appendChild(dv);

                $("#"+identifikacija).draggable();
                $("#"+identifikacija).resizable();
                $("#"+identifikacija).mouseover(function(){
                    $("#"+identifikacija).css("cursor","move");
                });

                $("#"+identifikacija).dblclick(function(){
                    var x=Math.floor(Math.random() * 256);
                    var y=Math.floor(Math.random() * 256);
                    var z=Math.floor(Math.random() * 256);
                    var bgc="rgb("+x+","+y+","+z+")";

                    $(this).css("background-color",bgc);
                });

                $("#"+identifikacija).mousedown(function(){
                    if(event.which == 2)
                        $(this).remove();
                });

                $("#"+identifikacija).contextmenu(function(){

                    document.oncontextmenu = function(e){
                    var evt = new Object({keyCode:93});
                    stopEvent(e);
                    keyboardUp(evt);
                    }

                    function stopEvent(event){
                        if(event.preventDefault != undefined)
                            event.preventDefault();
                        if(event.stopPropagation != undefined)
                            event.stopPropagation();
                    }

                    // $(this).css("transform","rotate("+stepen+"deg)");
                    // stepen+=15;
                    // if(stepen==360)
                    //     stepen=0;

                    $("#menu").show();
                    $("#test").click(function(){

                        $("#"+identifikacija).hide();
                        $("#menu").hide();
                    });
                });
            });

            $("#noviZaobljeni").click(function(){
                var stepen=15;
                ++vrijednost;
                var dvr = document.createElement("div");
                var identifikacija="action"+vrijednost;
                dvr.style.border="1px solid black";
                dvr.style.height="100px";
                dvr.style.width="100px";
                dvr.style.borderRadius="50%";
                dvr.style.transform="rotate(0deg)"; 
                dvr.id="action"+(vrijednost);
                dvr.ondblclick="changeColor("+action+vrijednost+")";
                dvr.title="Double click for changing the background color"
                dvr.style.position="absolute";
                document.body.appendChild(dvr);

                $("#"+identifikacija).draggable();
                $("#"+identifikacija).resizable();
                $("#"+identifikacija).mouseover(function(){
                    $("#"+identifikacija).css("cursor","move");
                });

                $("#action"+vrijednost).dblclick(function(){

                    var x=Math.floor(Math.random() * 256);
                    var y=Math.floor(Math.random() * 256);
                    var z=Math.floor(Math.random() * 256);
                    var bgc="rgb("+x+","+y+","+z+")";

                    $(this).css("background-color",bgc);
                });

                $("#"+identifikacija).mousedown(function(){
                    if(event.which == 2)
                        $(this).remove();
                });
                $("#"+identifikacija).contextmenu(function(){

                    document.oncontextmenu = function(e){
                    var evt = new Object({keyCode:93});
                    stopEvent(e);
                    keyboardUp(evt);
                    }

                    function stopEvent(event){
                        if(event.preventDefault != undefined)
                            event.preventDefault();
                        if(event.stopPropagation != undefined)
                            event.stopPropagation();
                    }

                //     $(this).css("transform","rotate("+stepen+"deg)");
                //     stepen+=15;
                //     if(stepen==360)
                //         stepen=0;

                    $("#menu").show();
                        $("#test").click(function(){

                            $("#"+identifikacija).hide();
                            $("#menu").hide();
                        });
                });
            });

});