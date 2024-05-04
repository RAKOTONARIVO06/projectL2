<?php
session_start();
if(!isset($_SESSION['name']) && !isset($_SESSION['NUM_ETUDIANT'])){
    header("location:pseudo.php");
}
else{
    $name=$_SESSION['name'];
    $NUM_ETUDIANT=$_SESSION['NUM_ETUDIANT'];
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="bootstrap.min.css">
    <link rel="stylesheet" href="style.css">
    <script src="bootstrap.min.js"></script> 
    <script src="script.js"></script>
    <title>Document</title>
</head>
<body style="background-color:antiqwhaite;">
    <?php
   
    include("connexion.php");
    
    ?>

    <nav class="navbar navbar-inverse navbar-fixed-top" style="box-shadow:0px 0px 10px black;margin-bottom:0px;">
       <div class="container">
           <div class="navbar-brand">
               <img src="dé.png" width="32" height="32">
           </div>
           <div>
                <a href="" class="navbar-brand" style="padding-top:20px;"><strong class="animation" style="color:White;">GOODLUCK EVERYBODY</strong> </a>
           </div>
           <div class="container">
              <ul class="nav navbar-nav navbar-right">
                  <li><a href="index.php" title="LOGOUT"><img src="log.png" width="32" heigth="32"></a></li>
              </ul>
           </div>
       </div>
    </nav>

    <div class="container" style="margin-top:100px;">
       <h3 style="text-align:center;">HELLO <strong style="color:red;"><?php if(isset($name) && $name != ""){
        echo $name;
        }else {
            echo"inconito";
        }
        ?>
         !!</strong> I wish you to have
           a good marks for your test.</h3>
          <center> <h3>You can push the button Envoyer Only One!</h3></center>
      <h3 style="text-align:center;color:green;">GOODLUCK!!</h3>

      <p><? if(isset($error)) echo $error;?> </p>
    </div>
    

    <div class="container bg-warning" style="height:100%; width:50%; box-shadow:0px 0px 5px blue;padding:30px;">
        <form action="EXAMEN.php" method="POST">
        <?php
            $sql="SELECT * FROM QCM ORDER BY rand() limit 10";
            $name=$_SESSION['name'];
            
            $req=mysqli_query($conn,$sql);
           echo"<ol>";
                 while($row=mysqli_fetch_assoc($req)){
                     $id=$row['id'];
                     $NUM_QUEST=$row['NUM_QUEST'];
                     $QUESTION=$row['QUESTION'];
                     $REPONSE1=$row['REPONSE1'];
                     $REPONSE2=$row['REPONSE2'];
                     $REPONSE3=$row['REPONSE3'];
                     $REPONSE4=$row['REPONSE4'];
        
        
                    $vrai=0;
                     $absolu=0;
                     $true=0;
                     $evidement=0;

                     if($NUM_QUEST<5){$vrai=1;}
                     elseif($NUM_QUEST<10){$absolu=1;}
                     elseif($NUM_QUEST<15){$true=1;}
                     else{$evidement=1;}
        ?>

                <h3 style="font-size:15px;font-weight:bold;"><li><?=$QUESTION?></li></h3>
                <div class="choice">
                    <div class="choice">
                        <input type="radio" name="<?=$NUM_QUEST?>" value="<?=$vrai?>">&NonBreakingSpace;<?=$REPONSE1?><br>
                    </div>
                    <div class="choice">
                       <input type="radio" name="<?=$NUM_QUEST?>" value="<?=$absolu?>">&NonBreakingSpace;<?=$REPONSE2?><br>
                    </div>
                    <div class="choice">
                        <input type="radio" name="<?=$NUM_QUEST?>" value="<?=$true?>">&NonBreakingSpace;<?=$REPONSE3?><br>
                    </div>
                    <div class="choice">
                        <input type="radio" name="<?=$NUM_QUEST?>" value="<?=$evidement?>">&NonBreakingSpace;<?=$REPONSE4?><br>
                    </div> 
                   
                </div>
                <?php
                }
            ?>

        <input type="submit" name="button">
        </form>
        <div>
        <?php
            if(isset($_POST['button'])){
            $success="You have finished your test";
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
       
       if(isset($note)){
       $sql="INSERT INTO EXAMEN VALUES(NULL,'$NUM_ETUDIANT','2022-2023','$note')";
       if(mysqli_query($conn,$sql))
       echo $note;
       header("Location:pseudo.php");
      }
    ?>
        </div>
    </div>
   
</body>
</html>

