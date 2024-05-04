<?php 
  session_start();
  if(isset($_POST['button'])){
      include("connexion.php");
      $sql="SELECT * FROM etudiant";
      $sql2="SELECT * FROM examen";
      $req=mysqli_query($conn,$sql);
      $req2=mysqli_query($conn,$sql2);
      if(isset($_POST['name']) && isset($_POST['NUM_ETUDIANT'])){
         if(isset( $_SESSION['email'] )){
             while($ligne=mysqli_fetch_assoc($req)){
                 if($ligne['NUM_ETUDIANT'] != $_POST['NUM_ETUDIANT']){
                     $error="Vous n'êtes pas encore inscrit en tant qu'étudiant";
                 }
                 else{
                       $error=1;
                        while($line2=mysqli_fetch_assoc($req2)){
                            if($line2['NUM_ETUDIANT']==$_POST['NUM_ETUDIANT']){
                                $error="Vous avez déja fait votre examen";
                                break;
                            } 
                            else{
                                $error=1;
                            }
                     } 
                     if( $error==1){
                        header("Location:examen.php");
                     }
                     break;                 
                   } 
                }

         $_SESSION['name']=$_POST['name'];
         $_SESSION['NUM_ETUDIANT']=$_POST['NUM_ETUDIANT'];
         
        }
     }
  }
?>



<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="bootstrap.min.css">
    
    <script src="bootstrap.min.js"></script> 
    <script src="script.js"></script>
    <title>Document</title>
</head>
<body style="background-color:antiquewhite;margin-top:80px;">
<div class="container" style="margin-top:20px; border:0px solid black; padding:30px;">
    <center><h3 class="text-primary">Veuillez remplir les champs</h3></center>
    </legend>
    <form action="pseudo.php" method="POST">
       <center> <p class="text-danger"><?php if (isset($error)) echo $error;  ?></p> </center>
        <label>Pseudo</label>
        <input type="text" name="name" class="form-control" placeholder="Facultatif" value="" ><br>
        <label>Mattricule</label>
        <input type="text" name="NUM_ETUDIANT" class="form-control" placeholder="Obligatoire" value="" required> <br>
        <center><input type="submit"  class="btn btn-success" name="button" value="Inserer">&NonBreakingSpace;
        <a href="index.php">retour</a></center>
    </form>
    </div><br><br>
</body>
</html>