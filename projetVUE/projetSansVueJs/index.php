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
   
   <body class="p-3 mb-2 bg-light-subtle text-emphasis-light">
      <div class=" container">
        <div  style="margin-top: 50px;">
            <form class="d-flex" role="search" style="max-width:80% ;">
                <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
                <button class="btn btn-outline-success" type="submit">Search</button>
            </form>
        </div>
      </div>
      <div>
      <div class="container">
        <div class="card text-bg-default mb-3" style="max-width: 90%">
            <div class="card-header" style="height: 70px;">
              <a href="formulaire.php"   style="float:right;"><button type="button" class="btn btn-outline-primary">+ Add</button></a>
               <h5 style="">Header</h5>
            </div>
            <div class="card-body">
                <table class="table">
                    <thead>
                      <tr>
                        <th scope="col" style="padding-left: 45px;">Action</th>
                        <th scope="col" >nom_Client</th>
                        <th scope="col">nom_Banque</th>
                        <th scope="col">montant</th>
                        <th scope="col">date_pret</th>
                        <th scope="col">montant_à_payer</th>
                      </tr>
                    </thead>
                    <tbody>
                    <?php
                    include_once ('connexion.php');
                    $sql="SELECT * FROM pret ";
                    
                    if(isset($_GET['search'])){
                    extract($_GET);
                    if(!empty($val)){
                        $sql="SELECT * FROM etudiant WHERE NUM_ETUDIANT LIKE '%$val%' OR NOM LIKE '%$val%'";
                    }
                    else{
                       $message=" AUCCUN ETUDIANT CORRESPONDANT A VOTRE RECHERCHE";
                    }
                    }
                $req=mysqli_query($conn,$sql);
                if(mysqli_num_rows($req) == 0){
                    echo " Aucun étudiant n'est ajouté";
                }
                else{
                    $somme=0;
                    while($row=mysqli_fetch_assoc($req)){
                ?>
                     <div class="container" style="">
                <tr>
                    <div class="container">
                        <th scope="row"><a href="supprimer.php?id=<?= $row['numCompte']?>"><button type="button" class="btn btn-outline-danger"
                            style="
                            --bs-btn-font-size:15px;">Delete
                            </button></a>
                            <a href="modifier.php?id=<?= $row['numCompte']?>"><button type="button" class="btn btn-outline-success"
                            style=" --bs-btn-font-size: 15px;" name="modifier">Update
                            </button></a>
                            
                        </th>
                        <td scope="col"><?= $row['nomClient'] ?></td>
                        <td scope="col"><?= $row['nomBanque'] ?></td>
                        <td scope="col"><?= $row['montant'] ?></td>
                        <td scope="col"><?= $row['datePret'] ?></td>
                       <?php $a=$row['tauxDePret'];
                           $b=$row['montant'];
                           $total=$b*(1+$a);
                           $somme=$somme+$total;
                           $ref=$total;
                           $tab=[];
                           array_push($tab,$total);
                           sort($tab);
                           
                       ?>
                        <td scope="col"><?= $total ?></td>
                        <?php ?>
                       
                    </div>
                </tr>
                </div>
                <?php
              }
            }
          ?>
                    </tbody>
                  </table>
            </div>
            
        </div>
        <div>
            La somme total à payer est: <?php echo $somme;?><br>
        
        </div>
       </div>
</body>
</html>


