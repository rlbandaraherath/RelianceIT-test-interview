<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="user.aspx.cs" Inherits="forinterview2.user" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    
    <hr />
    <div class="row">
        <div class="col-lg-2"></div>
        <div class="col-lg-2">
            <lable>ID</lable>
        </div>
        <div class="col-lg-1">
            <asp:TextBox ID="txtid" runat="server" placeholder=""></asp:TextBox>
        </div>
    </div>
    <br/>
            <div class="row">
                <div class="col-lg-2"></div>
                <div class="col-lg-2">
                    <lable>Name</lable>
                </div>
                <div class="col-lg-1">
                    <asp:TextBox ID="Txtname" runat="server" placeholder=""></asp:TextBox>
                </div>
            </div>
    </br/>
            <div class="row">
                <div class="col-lg-2"></div>
                <div class="col-lg-2">
                    <lable>DOB</lable>
                </div>
                <div class="col-lg-1">
                    <asp:TextBox ID="txtdob" runat="server" TextMode="Date" placeholder="Select a date"></asp:TextBox>
                </div>
            </div>

    <br />
    <div class="row">
        <div class="col-lg-2"></div>
        <div class="col-lg-2">
            <lable>Salary</lable>
        </div>
        <div class="col-lg-1">
<asp:TextBox ID="txtsalary" runat="server" placeholder="" type="number" onkeypress="return isNumberKey(event)" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-2"></div>
        <div class="col-lg-2">
            <lable>Active</lable>
        </div>
        <div class="col-lg-1">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Active" />
        </div>
    </div>
     <div class="row">
        <div class="col-lg-3"></div>
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
    </div>
</asp:Content>




