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
        if(isset($NUM_ETUDIANT) && isset($NOM) && isset($PRENOM) && isset($NIVEAU) && isset($A_EMAIL))
        {    
            if($NIVEAU === 'L1'|| $NIVEAU  === 'L2' || $NIVEAU === 'L3' || $NIVEAU === 'M1' || $NIVEAU === 'M2' ){
                include_once("connexion.php");
                $sql="UPDATE etudiant SET NUM_ETUDIANT='$NUM_ETUDIANT', NOM='$NOM' ,PRENOM='$PRENOM',
                 NIVEAU='$NIVEAU', A_EMAIL='$A_EMAIL' WHERE id=$id";
                 $request=mysqli_query($conn,$sql);
                 if($request){
                    header("Location:crude.php");
                }
                else{
                    $message="Etudiant non modifié!!";
                }
            }
           else{
                    $message="Etudiant non modifié,
                    l'étudiant doit etre de niveau L1,L2,L2,M1,M2 !!";
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
    <div class="container bg-primary" style="margin-top:100px;padding-bottom:50px;box-shadow:0px 0px 6px black;border-radius:300px;">
        <div>
            <h2 style="text-align:center ;">Modifié l'étudiant</h2>
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
        <div class="container" style="width:40%;">
            <div class="row" >
                <form action="" method="POST">
                    <div class="form-group col-md-6">
                        <label>num_matt</label>
                        <input type="text" name="NUM_ETUDIANT" style="border-radius:100px; width:220px;" class="form-control" placeholder="Numero mattricule" required>
                    </div>
                    <div class="form-group col-md-6">
                        <label >Nom</label>
                        <input type="text" name="NOM" style="border-radius:100px; width:220px;" class="form-control" placeholder="Nouveau Nom" required >
                    </div>
                    <div class="form-group col-md-6">
                        <label >Prénoms</label>
                        <input type="text" name="PRENOM" style="border-radius:100px; width:220px;" class="form-control" placeholder="Nouveau Prénom" required >
                    </div>
                    <div class="form-group col-md-6">
                        <label >Niveau</label>
                        <input type="text" name="NIVEAU" style="border-radius:100px; width:220px;" class="form-control" placeholder="choix entre L1 à M2" required>
                    </div>
                    <center><div class="form-group col-md-12">
                        <label >Email</label>
                        <input type="email" name="A_EMAIL" style="border-radius:100px; width:220px;" class="form-control" placeholder="Entrer votre e-mail" required>
                    </div></center>
                    <center><div>
                    <input type="submit"  class="btn btn-primary active btn-sm" value="MODIFIER" style="text-align:center;" name="button">
                    <a href="crude.php" type="btn btn-info" style="color:white;">RETOUR</a>
                    </div></center>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
