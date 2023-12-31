<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f0f0f0;
        }
        .header {
            background-color: #333;
            color: #fff;
            padding: 10px;
            display: flex;
            align-content: center;
            text-align:center;
        }
        .container {
            max-width: 800px;
            margin: 20px auto;
            background-color: #fff;
            padding: 20px;
        }
        .select-container {
            display: flex;
            justify-content: space-between;
        }
        select {
            padding: 5px;
            }
        .attendance-table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        .attendance-table th, .attendance-table td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: center;
        }
        .attendance-table th {
            background-color: #333;
            color: #fff;
        }
    </style>
</head>
<body>
    
            <form runat = "server">
    <div class="header">
        <div><center>ATTENDANCE PUBLIC RECORDS</center></div>
    </div>
    <div class="container">
        <div class="select-container">
                <asp:TextBox ID="name" runat="server" placeholder="Enter Student Name" OnTextChanged="name_TextChanged" Width="288px"></asp:TextBox>
                <asp:DropDownList ID="month" runat="server" OnSelectedIndexChanged="month_SelectedIndexChanged" Width="230px">
                    <asp:ListItem Value="1">January</asp:ListItem>
                    <asp:ListItem Value="2">February</asp:ListItem>
                    <asp:ListItem Value="3">March</asp:ListItem>
                    <asp:ListItem Value="4">April</asp:ListItem>
                    <asp:ListItem Value="5">May</asp:ListItem>
                    <asp:ListItem Value="6">June</asp:ListItem>
                    <asp:ListItem Value="7">July</asp:ListItem>
                    <asp:ListItem Value="8">August</asp:ListItem>
                    <asp:ListItem Value="9">September</asp:ListItem>
                    <asp:ListItem Value="10">October</asp:ListItem>
                    <asp:ListItem Value="11">November</asp:ListItem>
                    <asp:ListItem Value="12">December</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="year" runat="server" OnSelectedIndexChanged="year_SelectedIndexChanged" Width="119px">
                    <asp:ListItem Value="2022">2022</asp:ListItem>
                    <asp:ListItem Value="2023">2023</asp:ListItem>
                    <asp:ListItem Value="2024">2024</asp:ListItem>
                </asp:DropDownList>
                
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="UPDATE" Width="130px" />
                
        </div>
        <table class="attendance-table">
            <thead>
                <tr>
                    <th style="width:40%%;">Name</th>
                    <th style="width:20%;">Date</th>
                    <th style="width:20%;">Time In</th>
                    <th style="width:20%;">Time Out</th>
                </tr>
            </thead>
            <tbody>
            <asp:Repeater ID="attendanceRepeater" runat="server">
              <ItemTemplate>
                <tr onclick='<%# "rowClicked(\"" + Eval("Name") + "\", \"" + GetFormattedDate(Eval("Date")) + "\", \"" + GetFormattedTime_query(Eval("TimeIn")) + "\", \"" + GetFormattedTime_query(Eval("TimeOut")) + "\")" %>' style="cursor:pointer;">
                  <td><%# Eval("Name") %></td>
                  <td><%# GetFormattedDate(Eval("Date")) %></td>
                  <td><%# GetFormattedTime_query(Eval("TimeIn")) %></td>
                  <td><%# GetFormattedTime_query(Eval("TimeOut")) %></td>
                </tr>
              </ItemTemplate>
            </asp:Repeater>
        </tbody>
        </table>
    </div>
    <div class="container">
        <table class="attendance-table">
            <thead>
                <tr>
                    <h1><center>PICTURE</center></h1>
                    <th>TIME IN<br>
                        &nbsp;<asp:Image ID="timeinImg" runat="server" Height="200px" Width="200px" />
                    </th>
                    <th>TIME OUT<br>
                        &nbsp;<asp:Image ID="timeoutImg" runat="server" Height="200px" Width="200px" />
                    </th>
                </tr>
            </thead>
            <tbody>
                <!-- Populate this table with attendance data using JavaScript -->
            </tbody>
        </table>
        <br />
        <center><asp:Label runat="server" ID="pageTotal" Text="Page 1"></asp:Label></center>
        <br />
        <center>
                <asp:Button ID="btnPrevious" runat="server" Text="Previous" OnClick="btnPrevious_Click" Height="50px" Width="100px" />
                <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" Height="50px" Width="100px" />
            
        </center>
    </div>
    <center>CLICK THE RECORD(ROW) TO VIEW THE IMAGE</center><br />
    <center>IF THERE'S NO IMAGE, THERE MIGHT BE PROBLEM ON CAMERAS OR THE STUDENT IS EXCUSED</center>
    </form>
        <br />
        <br />
        <br />
</body>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script>
    function rowClicked(Name, Date, TimeIn, TimeOut) {
        var rowData = {
            Name: Name,
            Date: Date,
            TimeIn: TimeIn,
            TimeOut: TimeOut
        };

        console.log("before ajax");
        $.ajax({
            type: "POST",
            url: "WebForm1.aspx/HandleRowClick",
            data: JSON.stringify(rowData),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                if (response && response.d && typeof response.d === 'string') {
                    handleImageUpdate(response.d); 
                } else {
                    console.error('Invalid or missing data received:', response);
                }
                console.log("date: " + JSON.stringify(rowData));
            },
            error: function (xhr, status, error) {
                console.error("Error calling server method: " + error);
                alert("Error updating attendance data for " + JSON.stringify(rowData));
                console.log("date: " + JSON.stringify(rowData));
            }
        });
    }

    function handleImageUpdate(data) {
        try {
            var imgUrls = data.split('~').map(url => url.trim()); 
            if (imgUrls.length >= 2) {
                console.log(imgUrls[0]);
                if (imgUrls[0].includes('base64')) {
                    document.getElementById('timeinImg').setAttribute('src',imgUrls[0]);
                    document.getElementById('timeoutImg').setAttribute('src',imgUrls[1]);
                }
                else {
                    document.getElementById('timeinImg').src = imgUrls[0]; // Updating TimeIn Image URL
                    document.getElementById('timeoutImg').src = imgUrls[1]; // Updating TimeOut Image URL
                }
                    
            } else {
                console.error('Invalid format of image URLs:', imgUrls);
            }
        } catch (error) {
            console.error('Error occurred while handling image update:', error);
        }
    }



</script>
</html>


