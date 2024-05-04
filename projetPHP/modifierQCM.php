<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="bootstrap.min.css">
    <title>Document</title>
</head>
<body style="background-color:rgba(44,62,80,0.8);">
<?php
     $id=$_GET['id'];
     if(isset( $_POST['button'])){
        extract($_POST);
        if(isset($NUM_QUEST) && isset($QUESTION) && isset($REPONSE_1) && isset($REPONSE_2) && isset($REPONSE_3) && isset($REPONSE_4))
        {    
                include_once("connexion.php");
                $sql="UPDATE QCM SET QUESTION='$QUESTION', REPONSE1='$REPONSE_1' ,REPONSE2='$REPONSE_2',
                 REPONSE3='$REPONSE_3',REPONSE4='$REPONSE_4' WHERE id = '$id'";
                 $request=mysqli_query($conn,$sql);
                 if($request){
                    header("Location:QCM.php");
                }
                else{
                    $message="QCM non ajouté!!";
                }
        }
       else{
        $message="Remplir tous les champs!!";
        }
    }
    
?>   
<nav class="navbar navbar-inverse navbar-fixed-top" style="box-shadow:0px 0px 10px black;margin-bottom:0px;">
<div class="container">
    <div>
         <a href="" class="navbar-brand">GESTION DES QUESTIONNAIRES</a>
    </div>
    <div class="container">
       <ul class="nav navbar-nav navbar-right">
           <li><a  id="toolti" href="index.php" title="ACCUEIL" style="margin-right:50px;"><img src="home.png" width="25" heigth="25" alt=""></a></li>
           <li><a href="" title="LISTE DES ETUDIANTS" style="margin-right:50px;"><img src="students.png" width="25" heigth="25" alt="">
           </a></li>
           <li><a href="QCM.php" title="LES QCM" style="margin-right:50px;"><img src="question.png" width="25" heigth="25" alt=""></a></li>
           <li><a href="listeMarks.php" title="Liste des notes des étudiants" style="margin-right:370px;"><img src="exam.png" width="25" heigth="25"></a></li>
           <li><a href="login.php" style="margin:0px;" title="LOGOUT"><img src="log.png" width="30" height="25"></a></li>
       </ul>
    </div>
</div>
</nav>
   

    <div class="container bg-primary" style="margin-top:100px;padding-bottom:50px;border-radius:100px; box-shadow:0px 0px 6px red;">
        <div>
            <h2 style="text-align:center ;">Modifié le QCM</h2>
        </div>
        <div>
            <?php if(isset($message)){?>
                <p style="text-align:center;color:red;font-size:20px;
                 background-color:white;padding:20px;text-shadow:0px 0px 6px black;width:400px;
                 margin-left:360px; box-shadow:0px 0px 4px blue;"><?php echo $message;?></p>
            <?php
             } 
            ?>
        </div><br>
        <div class="container" style="width:60%;">
            <div class="row" >
                <form action="" method="POST">
                    <div class="form-group col-md-4" >
                        <label>NUM_QUEST</label>
                        <input type="number" name="NUM_QUEST" class="form-control" style="border-radius:100px; width:220px;" value=" " required>
                    </div>
                    <div class="form-group col-md-4" >
                        <label >QUESTION</label>
                        <input type="text" name="QUESTION" class="form-control" style="border-radius:100px; width:220px;" value="<?php ?> " required >
                    </div>
                    <div class="form-group col-md-4" >
                        <label >REPONSE_1</label>
                        <input type="text" name="REPONSE_1" class="form-control" style="border-radius:100px; width:220px;" value="<?php if(isset($REPONSE_1)) echo $REPONSE_1;?> " required >
                    </div>
                    <center><div class="form-group col-md-6">
                        <label >REPONSE_2</label>
                        <input type="text" name="REPONSE_2" class="form-control" style="border-radius:100px; width:220px;" value="<?php if(isset($REPONSE_2)) echo $REPONSE_2;?> " required>
                    </div></center>
                    <div class="form-group col-md-6">
                        <label >REPONSE_3</label>
                        <input type="text" name="REPONSE_3" class="form-control" style="border-radius:100px; width:220px;" value="<?php if(isset($REPONSE_3)) echo $REPONSE_3;?> " required>
                    </div>
                    <center><div class="form-group col-md-12">
                        <label >REPONSE_4</label>
                        <input type="text" name="REPONSE_4" class="form-control" style="border-radius:100px; width:220px;" value="<?php if(isset($REPONSE_4)) echo $REPONSE_4;?> " required>
                    </div></center>
                    <center> <div>
                    <input type="submit"  class="btn btn-primary active btn-sm" value="MODIFIER" style="text-align:center;" name="button">
                    <a href="QCM.php" type="btn btn-success" style="color:white">RETOUR</a>
                    </div></center>
                   
                </form>
            </div>
        </div>
    </div>
</body>
</html>
