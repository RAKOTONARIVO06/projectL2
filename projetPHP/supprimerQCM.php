<?php
   include ("connexion.php");
   $id= $_GET['id'];
   $request = mysqli_query($conn , "DELETE  FROM QCM WHERE NUM_QUEST = $id");
   header("Location:QCM.php");
?>