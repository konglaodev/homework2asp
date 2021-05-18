<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="homwork2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>asp2 homework</title>
    <style>
          
body{
    display:flex;
    justify-content:center;
    align-items:center;
    flex-direction:column;
    font-family:Phetsarath OT;
}
.divForm{
    width:300px;
    height:380px;
}
.form{
    display:flex;
    justify-content:center;
    align-items:center;
    flex-direction:column;
}
.form-input{
    display:flex;
    justify-content:space-between;
    align-items:center;
    margin-top:5px;
}
.language{
        display:flex;
    justify-content:center;
    align-items:center;
    flex-direction:column;
}
.btn{
    float:right;
    width:100px;
    height:40px;
    background:green;
    color:#fff;
    margin-top:-20px;
    font-size:15pt;
    border:none;
}
#show_error{
    color:red;
    font-weight:600;
    font-size:25pt;
}
    </style>
</head>
<body>
     <h1>ກະລຸນາປ້ອນຂໍ້ມູນຂອງທ່ານ</h1>
    <form id="form1" runat="server" class="form">
        <div class="divForm">
                    <div class="form-input">
            <asp:Label id="lblText1" runat="server" Text="ລະຫັດ" font-Name="Phetsarath OT"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox id="id"  runat="server"  font-Name="Phetsarath OT" class="box"></asp:TextBox>
        </div>
        <div class="form-input">
             <asp:Label id="Label1" runat="server" Text="ຊື່" font-Name="Phetsarath OT"></asp:Label>
             <asp:TextBox id="name"  runat="server"  font-Name="Phetsarath OT" class="box"></asp:TextBox>
        </div>
        <div class="form-input">
             <asp:Label id="Label2" runat="server" Text="ນາມສະກຸນ" font-Name="Phetsarath OT"></asp:Label>
             <asp:TextBox id="surname"  runat="server"  font-Name="Phetsarath OT" class="box"></asp:TextBox>
        </div>
        <div class="form-input">
            <asp:Label id="Label3" runat="server" Text="ເພດ" font-Name="Phetsarath OT"></asp:Label>
            <asp:RadioButton ID="female" runat="server" Text=" ຍິງ" />
            <asp:RadioButton ID="male" runat="server" Text="ຊາຍ"/>
        </div>
         <div class="form-input">
             <asp:Label id="Label10" runat="server" Text="ອີເມວ" font-Name="Phetsarath OT"></asp:Label>
         <asp:TextBox id="email"  runat="server"  font-Name="Phetsarath OT" class="box"></asp:TextBox>
        </div>
        <div class="form-input">
             <asp:Label id="Label11" runat="server" Text="ລະຫັດປະເທດ" font-Name="Phetsarath OT"></asp:Label>
             <asp:TextBox id="idcountry"  runat="server"  font-Name="Phetsarath OT" class="box"></asp:TextBox>
        </div>
        <div class="form-input">
             <asp:Label id="Label12" runat="server" Text="ສາຂາ" font-Name="Phetsarath OT"></asp:Label>
             <asp:DropDownList ID="major" runat="server">
                    <asp:ListItem Value="CS" Text="ວິທະຍາສາດຄອມພິວເຕີ"></asp:ListItem>
                    <asp:ListItem Value="CW" Text="ການພັດທະນາເວບໄຊ"></asp:ListItem>
                    <asp:ListItem Value="CPr" Text="ການພັດທະນາໂປຣແກຣມ"></asp:ListItem>
             </asp:DropDownList>
        </div>
        <div class="form-input">
            <div>
                  <asp:Label id="Label5" runat="server" Text="ພາສາໂປຣແກຣມທີ່ເຈົ້າມັກທີ່ສຸດ" font-Name="Phetsarath OT"></asp:Label>
            </div>
            <div class="language">
                <div>
                     <asp:CheckBox ID="java" runat="server" text="Java"/>
                </div>
                <div>
                     <asp:CheckBox ID="php" runat="server" text="PHP"/>
                </div>
                <div>
                    <asp:CheckBox ID="vb" runat="server" text="VB" />&nbsp;&nbsp;
                </div>
            </div>
        </div>
        </div>
         <asp:Button ID="Button1" runat="server" Text="ບັນທຶກ" font-Name="Phetsarath OT"   Class="btn" OnClick="Button1_Click"/>
         <asp:Label id="show_error" runat="server" Text=""></asp:Label>
        <br />
         <asp:GridView ID="GridView1" runat="server" Height="60px" Width="1000px"  font-Name="Phetsarath OT" BorderColor="#000" BorderStyle="None" BorderWidth="1px" CellPadding="1" CellSpacing="1" Font-Names="Phetsarath OT" style="margin-top: 0px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <FooterStyle BackColor="#f7dfb5" ForeColor="#8c4510" />
            <HeaderStyle BackColor="green" Font-Bold="true" ForeColor="White"/>
            <PagerStyle ForeColor="#8c4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#fff7e7" ForeColor="#8c4510" />
            <SelectedRowStyle BackColor="#738a9c" Font-Bold="true" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#fff1d4" />
            <SortedAscendingHeaderStyle BackColor="#b95c30" />
            <SortedDescendingCellStyle BackColor="#f1e5ce" />
            <SortedDescendingHeaderStyle BackColor="#93451f" />
        </asp:GridView>
       </form>
</body>
</html>