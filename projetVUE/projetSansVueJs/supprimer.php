<?php
   include ("connexion.php");
   $id= $_GET['id'];
   $request = mysqli_query($conn , "DELETE  FROM pret WHERE numCompte= '$id'");
   
   header("Location:index.php");
?>