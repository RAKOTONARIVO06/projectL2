<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/bootstrap-grid.min.css">
    <link rel="stylesheet" href="css/bootstrap-utilities.css">
    <link rel="stylesheet" href="css/bootstrap-utilities.rtl.min.css">
    <link rel="stylesheet" href="style.css">
    <title>Document</title>
</head>
<body>
    <?php
if(isset( $_POST['button'])){
        extract($_POST);
        if(isset($compte) && isset($name) && isset($banque) && isset($montant) && $taux)
        {    
                include ("connexion.php");
                $sql="INSERT INTO pret VALUES('$compte','$name','$banque',$montant,CURRENT_DATE,$taux)";
                $request=mysqli_query($conn,$sql);
                
                if($request){
                    $message="Enregistré avec success";
                    //header("Location:index.php");
                }
                else{
                    $error="Donnés non ajouté!!";
                    
               }
    
        }
       else{
        $message="Remplir tous les champs!!";
        }
    }
    if(isset($_GET['modifier'])){
        $id=$_GET['id'];
        $sql="SELECT * FROM etudiant WHERE numCompte=$id";
        $req=mysqli_query($conn,$sql);
        $name=10;

        //$sql="UPDATE etudiant SET NUM_ETUDIANT='$NUM_ETUDIANT', NOM='$NOM' ,PRENOM='$PRENOM',
        //NIVEAU='$NIVEAU', A_EMAIL='$A_EMAIL' WHERE id=$id";
        //$request=mysqli_query($conn,$sql);
        //if($request){
        //header("Location:crude.php");
        //}
        //else{
        //$message="Etudiant non modifié!!";
        //}
          }
    
?>    

<div class="container" style="width: 80%;">
<?php if(isset($message)) {?>
        <div class="alert alert success" role="alert">
          <p class="alert alert success"><?php echo $message?></p>  
        </div><?php } ?>

    <?php if(isset($error)){?>
       <div class="alert alert danger" role="alert"><?php echo $error?>
    </div>
    <?php }?>
<div class="card border-success mb-3" style="max-width: 90%; box-shadow: 0px 1px 10px black;padding:20px;">
   
    <div class="card-header bg-transparent border-success">
       <a href="index.php"><button type="button" class="btn-close" aria-label="Close" style="float:right; background-color: red;" ></button></a>
        
        <h5>Veuillez Remplir la formulaire</h5>
    </div>
        <div class="card-body text-success">
            <form class="row g-3 needs-validation" method="POST" action="formulaire.php">
        
                <div class="col-md-4">
                    <label for="validationCustom01" class="form-label">n*compte</label>
                    <div class="input-group has-validation">
                        <span class="input-group-text" id="inputGroupPrepend">@number</span>
                        <input type="text" class="form-control"  id="validationCustomUsername" aria-describedby="inputGroupPrepend" name="compte" placeholder="ex:1234556" required>
                    </div>
                </div>
                
                <div class="col-md-4">
                    <label for="validationCustom02" class="form-label">Nom du Client</label>
                    <div class="input-group has-validation">
                        <span class="input-group-text" id="inputGroupPrepend">@name</span>
                        <input type="text" class="form-control" id="validationCustomUsername" name="name" aria-describedby="inputGroupPrepend" placeholder="Nom complet" required>
                    </div>
                </div>
                <div class="col-md-4">
                    <label for="validationCustomUsername" class="form-label">nom_du_banque</label>
                    <div class="input-group has-validation">
                        <span class="input-group-text" id="inputGroupPrepend">@</span>
                        <input type="text" class="form-control" id="validationCustomUsername" name="banque" aria-describedby="inputGroupPrepend"  required>
                    </div>
                </div>
            
        
                <div class="col-md-6">
                    <label for="validationCustom03" class="form-label">Montant</label>
                    <div class="input-group has-validation">
                        <span class="input-group-text" id="inputGroupPrepend">@$</span>
                        <input type="text" class="form-control" id="validationCustomUsername" name="montant" aria-describedby="inputGroupPrepend" required>
                        <span class="input-group-text" id="inputGroupPrepend">.00 Ariary</span>
                    </div>
                </div>
                <div class="col-md-3">
                    <label for="validationCustom04" class="form-label">Date du prêt</label>
                    <div class="input-group has-validation">
                        <span class="input-group-text" id="inputGroupPrepend">@Date</span>
                        <input type="text" class="form-control" id="validationCustom03" name="date" disabled>
                    </div>
                </div>
                <div class="col-md-3">
                    <label for="validationCustom05" class="form-label">Taux du prêt</label>
                    <div class="input-group has-validation">
                        <input type="text" class="form-control" id="validationCustom05" name="taux" placeholder="taux du prêt" required >
                        <span class="input-group-text" id="inputGroupPrepend">%</span>
                    </div>
                </div>
        
        
                <div class="col-12">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="" id="invalidCheck" required>
                        <label class="form-check-label" for="invalidCheck">
                           Agree to terms and conditions
                        </label>
                    </div>
                </div>
                <div class="card-footer bg-transparent border-success">
                    <div class="col-12">
                        <button class="btn btn-primary" type="submit" style="float:right; margin-right: 50px;" name="button"> Valider</button>
                        <button class="btn btn-danger" type="reset" style="float: right; margin-right: 10px;"> Annuler</button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
</body>
</html>