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
     if(isset( $_POST['button'])){
        extract($_POST);
        if(isset($NUM_QUEST) && isset($QUESTION) && isset($REPONSE1) && isset($REPONSE2) && isset($REPONSE3) && isset($REPONSE4))
        {    
                include_once("connexion.php");
                $sql="INSERT INTO QCM VALUES(NULL,$NUM_QUEST,'$QUESTION','$REPONSE1','$REPONSE2','$REPONSE3','$REPONSE4')";
                $request=mysqli_query($conn,$sql);
                if($request){
                    header("Location:QCM.php");
                }
                else{
                    $message="QCM non ajouté!! Singleton en NUM_ETUDIANT";
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
           <li><a  id="toolti" href="crude.php" title="ACCUEIL" style="margin-right:50px;"><img src="home.png" width="25" heigth="25" alt=""></a></li>
           <li><a href="" title="LISTE DES ETUDIANTS" style="margin-right:50px;"><img src="students.png" width="25" heigth="25" alt="">
           </a></li>
           <li><a href="QCM.php" title="LES QCM" style="margin-right:50px;"><img src="question.png" width="25" heigth="25" alt=""></a></li>
           <li><a href="listeMarks.php" title="Liste des notes des étudiants" style="margin-right:370px;"><img src="exam.png" width="25" heigth="25"></a></li>
           <li><a href="index.php" style="margin:0px;" title="LOGOUT"><img src="log.png" width="30" height="25"></a></li>
       </ul>
    </div>
</div>
</nav>
    <div class="container bg-primary" style="margin-top:100px;padding-bottom:50px;border-radius:150px; box-shadow:0px 0px 6px black;">
        <div>
            <h2 style="text-align:center ;">Ajouté QCM</h2>
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
        <div class="container" style="width:60%">
            <div class="row" >
                <form action="" method="POST">
                    <div class="form-group col-md-4">
                        <label>NUM_QUEST</label>
                        <input type="number" name="NUM_QUEST" style="border-radius:100px; width:220px;" class="form-control" required>
                    </div>
                    <div class="form-group col-md-4">
                        <label >QUESTION</label>
                        <input type="text" name="QUESTION" style="border-radius:100px; width:220px;" class="form-control" required >
                    </div>
                    <div class="form-group col-md-4">
                        <label >REPONSE1</label>
                        <input type="text" name="REPONSE1" style="border-radius:100px; width:220px;" class="form-control" required >
                    </div>
                    <center><div class="form-group col-md-6">
                        <label >REPONSE2</label>
                        <input type="text" name="REPONSE2" style="border-radius:100px; width:220px;" class="form-control" required>
                    </div></center>
                    <div class="form-group col-md-6">
                        <label >REPONSE3</label>
                        <input type="text" name="REPONSE3" style="border-radius:100px; width:220px;" class="form-control" required>
                    </div>
                    <center><div class="form-group col-md-12">
                        <label >REPONSE4</label>
                        <input type="text" name="REPONSE4" style="border-radius:100px; width:220px;" class="form-control" required>
                    </div></center>
                    <center><div>
                    <input type="submit"  class="btn btn-primary active btn-sm" value="AJOUTER" style="text-align:center;" name="button">
                    <a href="QCM.php" type="btn btn-info" style="color:white;">RETOUR</a>
                    </div></center>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
