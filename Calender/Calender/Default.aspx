<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calender._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .other-month {
            background-color: gray;
        }
        .weekend {
            background-color: yellow;
        }
    </style>

    <main>
        <div>
            <asp:TextBox ID="SelectedDateTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="ShowCalendarButton" runat="server" Text="Show Calendar" OnClick="ShowCalendarButton_Click" /> <br><br>
            <asp:Calendar ID="CalendarControl" runat="server" OnSelectionChanged="CalendarControl_SelectionChanged" OnDayRender="CalendarControl_DayRender" Visible="false"></asp:Calendar>
        </div>
    </main>

</asp:Content>
