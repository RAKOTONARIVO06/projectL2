<?php
  if(isset($_SESSION['email'])){
      $success="bonjour";
  }
  else{
      $success="nonnnnnn";
  }
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
   <?php
    if(isset($_POST)){
        $note=0;
        foreach($_POST as $id => $val){
         if($val==1){
             $note=$note+1;
         }
         else{
             continue;
         }
      }
    }
     
    echo "vous avez obténu $note sur 10";
    ?>
</body>
</html>