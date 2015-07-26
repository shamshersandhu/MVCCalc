@Code
    ViewData("Title") = "ajaxtest"
End Code
<div class="jumbotron">
    @*<p>@ViewBag.Name</p>*@
    @*@Ajax.ActionLink("Get Date", "test", "ajaxtest", New AjaxOptions With {.HttpMethod = "Get", .UpdateTargetId = "timediv"})*@
    <h2 class="h2">Calculator</h2>

    <div class="well well-lg">
        <div id="ajax" class="input-group input-group-lg">
            <label class="label label-primary" for="expr1">Enter Expression:</label> <br />
            <input style="width:250px" maxlength="20" class="form-control" id="expr1" min="1" />
            <select style="width:200px" class="form-control" id="oper" onchange="opersel()">
                <option value="1">+ Plus</option>
                <option value="2">- Minus</option>
                <option value="3">&times; Multiplied by</option>
                <option value="4">&divide; Divided by</option>
                <option value="5">^ Raise to Pow.</option>
                <option value="6">√ Square Root</option>
            </select>
            <input style="width:250px" maxlength="20" class="form-control" id="expr2"  />
            <input class="btn btn-lg btn-primary" type="submit" value="&raquo; Go &raquo;" onclick="getresults()" />

        </div>
    </div>
    <div id="result">

    </div>
</div>
@Section MyScripts
    <script type="text/javascript">
    //    function updateTime() {
   //         $('#timediv').load('/ajaxtest/test');
   //     }
   //     setInterval("updateTime()", 1000);

        function getresults() {
            $('#result').load('/ajaxtest/calc?e1=' + $("#expr1").val() + '&e2=' +  $("#expr2").val() + '&op=' +  $("#oper").val());
       //     alert($("#expr1").val());
            return false;
        }

        function opersel() {
            var xv = $("#oper").val();
         //   alert(xv);
            if (xv == 6) {
                $("#expr2").hide();
            }
            else {
                $("#expr2").show();
            };
        }

        $(document).ready(function () {
                  
              $("#expr1").keydown(function (e) {
                // Allow: backspace, delete, tab, escape, enter and .
                if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
                    // Allow: Ctrl+A
                    (e.keyCode == 65 && e.ctrlKey === true) ||
                    // Allow: Ctrl+C
                    (e.keyCode == 67 && e.ctrlKey === true) ||
                    // Allow: Ctrl+X
                    (e.keyCode == 88 && e.ctrlKey === true) ||
                    // Allow: home, end, left, right
                    (e.keyCode >= 35 && e.keyCode <= 39)) {
                    // let it happen, don't do anything
                    return;
                }
                // Ensure that it is a number and stop the keypress
                if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
                    e.preventDefault();
                }
            });
            $("#expr2").keydown(function (e) {
                // Allow: backspace, delete, tab, escape, enter and .
                if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
                    // Allow: Ctrl+A
                    (e.keyCode == 65 && e.ctrlKey === true) ||
                    // Allow: Ctrl+C
                    (e.keyCode == 67 && e.ctrlKey === true) ||
                    // Allow: Ctrl+X
                    (e.keyCode == 88 && e.ctrlKey === true) ||
                    // Allow: home, end, left, right
                    (e.keyCode >= 35 && e.keyCode <= 39)) {
                    // let it happen, don't do anything
                    return;
                }
                // Ensure that it is a number and stop the keypress
                if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
                    e.preventDefault();
                }
            });
        });
    </script>

End Section


