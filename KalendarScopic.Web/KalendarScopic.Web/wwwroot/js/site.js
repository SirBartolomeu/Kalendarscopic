function daysInMonth() {
    //calcular total de dias do mês
    var months = document.getElementById("cal-mth");
    var selectedMonth = months.value;

    var years = document.getElementById("cal-yr");
    var selectedYear = years.value;

    monthNum = new Date(Date.parse(selectedMonth + " 1," + selectedYear)).getMonth() + 1
    var monthDays = new Date(selectedYear, monthNum, 0).getDate();

    var container = document.getElementById("cal-container"),
        cTable = document.createElement("table");
    cTable.id = "calendar";
    container.innerHTML = "";
    container.appendChild(cTable);

    //for para gerar os quadradados, linhas e colunas
    
    var cCell = document.createElement("td")


    var k = 0;
    var p = 0
    for (i = 1; i <= monthDays; i++) {
        
        if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29)
        {
            var cRow = cTable.insertRow(p);
            p = p + 1;
            k = 0;
        }
                       
        
        var cCell = cRow.insertCell(k);
        cCell.innerHTML = i;
        cCell.id = "cell" + i;
        cCell.setAttribute("data-toggle", "modal");
        cCell.setAttribute("data-target", "#eventModal");       
        k = k + 1;
        

    }


    return new Date(selectedYear, monthNum, 0).getDate();
}


//popular modal ao abri-lo
$(window).on('shown.bs.modal', function (e) {
    $('#eventModal').modal('show');

   
        var getIdCell = e.relatedTarget;
        var months = document.getElementById("cal-mth");
        var selectedMonth = months.value + "";
        var years = document.getElementById("cal-yr");
        var selectedYear = years.value + "";
        var selectedDay = getIdCell.innerHTML + "";
        if (selectedDay.length == 1) {
            selectedDay = "0" + selectedDay;
        }
        if (selectedMonth.length == 1) {
            selectedMonth = "0" + selectedMonth;
        }
        var d = selectedMonth + "-" + selectedDay + "-"  + selectedYear;
        var a = d.split("-");
        var date = new Date(a[2], (a[1] - 1), a[0]);
        var weekDay = date.getDay();
        var days = new Array("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday");
        

        exampleModalLabel.innerHTML = d + " " + days[weekDay];
        document.getElementById("AuthorId").value = document.getElementById("userId").innerHTML;
        //ajax call populate items


});


$("#eventNewForm").submit(function (event) {

    // Stop form from submitting normally
    event.preventDefault();

    // Get some values from elements on the page:
    var $form = $(this);
    //var data = $($(this)).serialize();
    var data =
    {
        AuthorId: $form.find("input[name='AuthorId']").val(),
        Title: $form.find("input[name='Title']").val(),
        Description: $form.find("input[name='Description']").val(),
        StartTime: $form.find("input[name='StartTime']").val(),
        EndTime: $form.find("input[name='EndTime']").val(),
        Tag: $form.find("input[name='Tag']").val(),
        IsGroup: $form.find("input[name='IsGroup']").val()

        
    }
       
    $.post('Home/CreateEvent', data);
    //    term = $form.find("input[name='s']").val(),
    //    url = $form.attr("action");

    //// Send the data using post
    //var posting = $.post(url, { s: term });

    //// Put the results in a div
    //posting.done(function (data) {
    //    var content = $(data).find("#content");
    //    $("#result").empty().append(content);
    //});
});