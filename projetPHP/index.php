<?php
session_start();
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


<body style="background-image:url(fond2.jpg);">
<?php
  if(isset($_POST['button'])){
    extract($_POST);
    $_SESSION['email']=$user;
    if(isset($user) && isset($pswd)){
        include("connexion.php");
        $sql="SELECT * FROM etudiant";
        $req=mysqli_query($conn,$sql);
        while($ligne=mysqli_fetch_assoc($req)){
             if($ligne['A_EMAIL'] == $user){
                 header("Location:pseudo.php");
             }
             $erreur="error !! you have entered a wrong email. Try again";
        }
        $erreur="error !! you have entered a wrong email. Try again";
    }
  }
?>
        <center><img src="customer1.png" height="190" width="150" style="margin-top:50px;"></center> 
    <div class="container" style="margin-top:-85px; height: 510px;width:40%;">
       <form action="" style="margin-top:125px; " method="POST">
            <p class="text-danger"><?php if (isset($erreur)) echo $erreur;?></p>
          <div class="form-input">
             <center><input type="email" name="user" class="form-control" style="width:65%;height: 50px;" placeholder="Enter your email" required></center>
          </div> <br><br>
          <div class="form-input">
             <center><input type="password" name="pswd" class="form-control" style="width:65%; height: 50px;" placeholder="Enter your password" required></center> 
          </div><br>
          <div class="form-group">
            <center><input type="submit" name="button" class="btn btn-success" value="login" style="padding:15px;"></center>
          </div>
       </form>
       <div class="col-sm-5 col-xs-1">
           <hr style="height: 1px; width:100px;">
      </div>
      <div class="col-sm-2 col-xs-1">
      <hr style="height:1px; width:20px">
      </div>
      <div class="col-sm-5 col-xs-1">
           <hr style="height: 1px; width:100px;">
       </div>
       <div class="col-xs-12">
             <p style="color:white;">Are you Administrator?</p>
       </div>
       <div class="col-xs-12">
           <img src="hand.png" height="20" width="20"><a style="color:blue;font-size:14px;font-weight:bold;" href="admin.php">Login with Administrator account</a>
       </div>
    </div>
</body>
</html>