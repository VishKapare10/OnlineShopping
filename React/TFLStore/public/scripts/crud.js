            //first fetch data from server
            //url  http://localhost:9898/api/flowers
            
            // PRC : Remote Procedural Call
            //ready made API provided by one standard javascript library
            //Library : jQuery 
        
            //set of reusable  javascript functions

            var  readAllData=function(data){

                var html = [];
                html.push("<table><thead><tr><th>ID</th><th>Title</th><th>Unit Price</th><th>Stock Available</th></tr></thead>");
                
                //insert  new Table  row for each json object received from REST API

                for(var i=0; i<data.length; i++) {
                    html.push("<tr>");
                    html.push("<td>");
                    html.push(data[i].id);
                    html.push("</td>");
                    html.push("<td>");
                    html.push(data[i].name);
                    html.push("</td>");
                    html.push("<td>");
                    html.push(data[i].unitprice);
                    html.push("</td>");
                    html.push("<td>");
                    html.push(data[i].quantity);
                    html.push("</td>");
                    html.push("</tr>");
                }
        
            html.push("</table>");
            document.getElementById("pId").innerHTML=JSON.stringify(data);
            var div1=document.getElementById("divData");
            div1.innerHTML=html.join('');
            };


        // Invoke server side data 

        var dataUrl="http://localhost:9898/api/flowers";

        // This function will fetch data from above url
        $.ajax({
                url:dataUrl,  // which url
                type:"GET",  // What is the type of request
                success:function(data){
                            console.log(data);
                            readAllData(data);
                        },
                error:function(err){
                            console.log(err);
                        }
        });