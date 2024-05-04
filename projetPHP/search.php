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
    <style> @media (min-width:268px){
        
    }
    </style>
    
</head>
<body style="background-color:#99;padding:0px;margin:0px;">
    <nav class="navbar navbar-inverse navbar-fixed-top" style="box-shadow:0px 0px 10px black;margin-bottom:0px;">
       <div class="container">
           <div>
                <a href="" class="navbar-brand">GESTION DES QUESTIONNAIRES</a>
           </div>
           <div class="container">
              <ul class="nav navbar-nav navbar-right">

                  <li><a href="" title="RECHERCHER UN ETUDIANT" style="margin-right:50px;"><img src="searck.png" width="25px;" height="25px;"></a></li>
                  <li><a  id="toolti" href="index.php" title="ACCUEIL" style="margin-right:50px;"><img src="home.png" width="25" heigth="25" alt=""></a></li>
                  <li><a href="" title="LISTE DES ETUDIANTS" style="margin-right:50px;"><img src="students.png" width="25" heigth="25" alt=""></a></li>
                  <li><a href="QCM.php" title="LES QCM" style="margin-right:50px;"><img src="question.png" width="25" heigth="25" alt=""></a></li>
                  <li><a href="" title="PASSER A L'EXAMEN"><img src="exam.png" width="25" heigth="25"></a></li>
              </ul>
           </div>
       </div>
    </nav>
    <div class="container bg-succes" style="padding:50px;height:100%;box-shadow:0px 0px 6px black;">
        <div class="bg-info" style="padding-top:50px; box-shadow:0px 50px 0px violet;">
           <h1 style="text-align:center;">LISTE DE TOUS LES ETUDIANTS INSCRITS <br> DANS LA BASE DE DONNEE</h1><br>
        </div><br>
        <div style="padding:50px;box-shadow:0px 0px 5px blue;" class="bg-danger">
                <form action="search.php" method="POST" class="form">
                    <div class="form-group">
                        <input type="search"  style="width:200px;height:30px;border:0;" placeholder="num_matt ou nom" name="val">
                        <a href="search.php" class="btn btn-danger btn-sm" name="search"><img src="search.png" width="18" height="18"></a>
                    </div>
                </form>
           <a href="ajouterOKAY.php" class="btn btn-success btn-sm"><img src="add.png" with="25" height="25"> AJOUTER</a><br><br>
           
           <table class="table1">
                <tr class="tr">
                    <div class="container">
                       <th>Num_matt</th>
                       <th>Nom</th>
                       <th>Prénom</th>
                       <th>Niveau</th>
                       <th>Email</th>
                       <th>Modifier</th>
                       <th>Supprimer</th>
                    </div>
                </tr>
                <?php
                include_once ('connexion.php');
                $sql="SELECT * FROM etudiant WHERE NUM_ETUDIANT OR NOM LIKE '%";
                $req=mysqli_query($conn,$sql);
                if(mysqli_num_rows($req) == 0){
                    echo " Aucun étudiant n'est ajouté";
                }
                else{
                    while($row=mysqli_fetch_assoc($req)){
                ?>
                <div class="container" style="">
                <tr>
                    <td><?= $row['NUM_ETUDIANT'] ?></td>
                    <td><?= $row['NOM'] ?></td>
                    <td><?= $row['PRENOM'] ?></td>
                    <td><?= $row['NIVEAU'] ?></td>
                    <td><?= $row['A_EMAIL'] ?></td>
                    <td><a href="modifier.php?id=<?= $row['id']?>"><img src="modify.png" width="25px" heigth="25px"></a></td>
                    <td><a href="supprimer.php?id=<?= $row['id']?>"><img src="delete.png" width="25px" heigth="25px"></a></td>
                </tr>
                </div>
                <?php
              }
            }
          ?>
       </table>
   </div>
   </div>
</body>
</html>