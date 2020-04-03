<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <link href="StyleSheet2.css" rel="stylesheet" />
    <link href="team.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" runat="server">
    
    <ul> 
        <li><a  href="login.aspx">Login</a> </li>
        <li><a  href="#contact">Contact Us</a> </li>
        <li><a  href="#about">About Us</a> </li>      
        <li><a  href="#services">Services</a> </li>            
        <li><a  href="#home">Home</a> </li>
        <li style="float:left"><img  src="image/logo.png" /> </li>
            
   </ul>
        
        <section id="home">
            <div data-aos="zoom-in">
  <div class="image">
 
  <img class="mySlides " src="image/2.jpg" />
  <img class="mySlides " src="image/3.jpg"/>
  <img class="mySlides " src="image/4.jpg" />
</div>

<script>
    var myIndex = 0;
    carousel();

    function carousel() {
        var i;
        var x = document.getElementsByClassName("mySlides");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        myIndex++;
        if (myIndex > x.length) { myIndex = 1 }
        x[myIndex - 1].style.display = "block";
        setTimeout(carousel, 3000); 
    }
</script>
</div>
 </section>
       
 <section id="services">
     
     <h1>Our Services</h1>
     <div class="pad">
     <div class="panel1">
     <asp:Panel ID="Panel1" runat="server">
         <img  src="image/i2.PNG" />
          <div class="lbl">
         <asp:Label ID="Label1" runat="server" Text="Android"></asp:Label></div>
         <h2> team specializes in designing and developing customized Mobile Apps and Mobile E-Learning Solutions, which are attractive, user-friendly and serve your purpose.</h2>
     </asp:Panel>
     </div>
     <div class="panel2">
         <img  src="image/i2.PNG" />
     <asp:Panel ID="Panel2" runat="server">
          <div class="lbl">
<asp:Label ID="Label2" runat="server" Text="Web Development"></asp:Label></div>
         <h2>It is highly necessary to establish a strong online presence in today’s competitive world. Our company delivers web designs that are good to look at, easy to navigate, fast to load and compatible across majority of the browsers.</h2>
     </asp:Panel>
         </div>
      <div class="panel3">
          <img  src="image/i3.PNG" />
     <asp:Panel ID="Panel3" runat="server">
          <div class="lbl">
<asp:Label ID="Label3" runat="server" Text="Logo Design"></asp:Label></div>
         <h2>A company logo epitomizes your business. It communicates your USP in a visually appealing manner to the target audience.</h2>
     </asp:Panel>
         </div>
     <div class="panel4">
         <img  src="image/i2.PNG" />
     <asp:Panel ID="Panel4" runat="server">
         <div class="lbl">
         <asp:Label ID="Label4" runat="server" Text="Windows Applications"></asp:Label></div>

         <h2>We develop user-friendly desktop applications tailored to... specific clients needs.</h2>
     </asp:Panel>
     </div>
     <div class="panel10">
     <asp:Panel ID="Panel10" runat="server">
         <img  src="image/i2.PNG" />
          <div class="lbl">
         <asp:Label ID="Label5" runat="server" Text="Android"></asp:Label></div>
         <h2> team specializes in designing and developing customized Mobile Apps and Mobile E-Learning Solutions, which are attractive, user-friendly and serve your purpose.</h2>
     </asp:Panel>
     </div></div>
     
 </section>
       <section id="about">
           <div class="panel5">
           <asp:Panel ID="Panel5" runat="server">
           <div class="container">
  <img src="image/android.jpg" alt="Avatar" class="image1"/>
  <div class="overlay">
    <div class="text">Android Development</div>
  </div>
</div>
         </asp:Panel> </div>
           <div class="panel6">
           <asp:Panel ID="Panel6" runat="server">
                <div class="container">
  <img src="image/web.jpg" alt="Avatar" class="image1"/>
  <div class="overlay">
    <div class="text">Web Design</div>
  </div>
</div>
           </asp:Panel></div>

            <div class="panel7">
            <asp:Panel ID="Panel7" runat="server">
                <div class="container">
  <img src="image/logo.jpg" alt="Avatar" class="image1"/>
  <div class="overlay">
    <div class="text">Logo Design</div>
  </div>
</div>
           </asp:Panel></div>
            <div class="panel9">
                
                
           <asp:Panel ID="Panel9" runat="server">
             
           </asp:Panel></div>
           </section> 
        <div class="panel8">
        <asp:Panel ID="Panel8" runat="server">
            <div class="panel11">
            <asp:Panel ID="Panel11" runat="server">
                <h4>Contact Us</h4>
                <div class="elable">
                <asp:Label ID="Label6" runat="server" Text="Name:"></asp:Label></div>
               <div class="etext">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="etext"></asp:TextBox></div>
                <br />
                <div class="elable">
                <asp:Label ID="Label7" runat="server" Text="Email:"></asp:Label></div>
                <div class="etext">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="etext"></asp:TextBox></div>
                <br />
                    <div class="elable">
                <asp:Label ID="Label8" runat="server" Text="City:"></asp:Label></div>
                <div class="etext">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="etext"></asp:TextBox></div>
                <br />
                        <div class="elable">
                <asp:Label ID="Label9" runat="server" Text="Mobile-No:"></asp:Label></div>
                <div class="etext">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="etext"></asp:TextBox></div>
                <br />
                            <div class="elable">
                <asp:Label ID="Label10" runat="server" Text="Message:"></asp:Label></div>
                <div class="etext">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="etext"></asp:TextBox></div>
                <br />
                    <div class="ebtn">
                <asp:Button ID="Button1" runat="server" Text="Send" CssClass="ebtn" /></div>
            </asp:Panel></div>
        </asp:Panel></div>
   </form>
    
</body>
</html>
