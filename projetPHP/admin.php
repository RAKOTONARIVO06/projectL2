<?php
  session_start();
  if(isset($_POST['button'])){
   $_SESSION['pswd']= $_POST['pswd'];
    include("connexion.php");
    if($_SESSION['pswd']=='1234567A'){
      header("Location:crude.php");
    }
  else{
      $error="Please try to remember the 8 characters";
  }
  }
?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="login.css">
    <link rel="stylesheet" href="bootstrap.min.css">
    <title>Document</title>
</head>
<?php
  
  

?>
<body style="background-image:url(fond2.jpg);margin-top:40px;">
        <center><img src="ad.png" height="180" width="150" style="margin-bottom:46px;"></center> 
    <div class="container" style="margin-top:-90px; height: 460px;width:40%;">
       <form action="" style="margin-top:125px; " method="POST">
          <p class="text-danger">
             <?php
             if(isset($error)) echo $error;
            ?>
          
          </p>
          
          <div class="form-input">
             <center><input type="password" name="pswd" class="form-control" style="width:65%; height: 50px;" placeholder="Enter the 8 caracters code" required></center> 
          </div><br>
          <div class="form-group">
            <center><input type="submit" name="button" class="btn btn-success" value="login" style="padding:15px;"></center>
          </div>
       </form>
       <div class="col-sm-5 col-xs-12">
           <hr style="height: 1px; width:100px;">
      </div>
      <div class="col-sm-2 col-xs-12">
      <hr style="height:1px; width:20px">
      </div>
      <div class="col-sm-5 col-xs-12">
           <hr style="height: 1px; width:100px;">
       </div>
        <div class="col-xs-12" >
            <p style="color:white;">Are you Student?</p>
        </div>
        <div class="col-xs-12">
            <img src="hand.png" height="20" width="20"><a style="color:blue;font-size:14px;font-weight:bold;" href="index.php">Login with Student account</a>
        </div>
    </div>
</body>
</html>