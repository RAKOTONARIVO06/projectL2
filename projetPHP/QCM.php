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
<body style="background-color:rgba(44,62,80,0.9);padding:0px;margin:0px;">
<nav class="navbar navbar-inverse navbar-fixed-top" style="box-shadow:0px 0px 10px black;margin-bottom:0px;">
       <div class="container">
           <div>
                <a href="" class="navbar-brand">GESTION DES QUESTIONNAIRES</a>
           </div>
           <div class="container">
              <ul class="nav navbar-nav navbar-right">
                  <li><a  id="toolti" href="crude.php" title="ACCUEIL" style="margin-right:50px;"><img src="home.png" width="25" heigth="25" alt=""></a></li>
                  <li><a href="listeTotal.php" title="LISTE DES ETUDIANTS" style="margin-right:50px;"><img src="students.png" width="25" heigth="25" alt="">
                  </a></li>
                  <li><a href="QCM.php" title="LES QCM" style="margin-right:50px;"><img src="question.png" width="25" heigth="25" alt=""></a></li>
                  <li><a href="listeMarks.php" title="Liste des notes des étudiants" style="margin-right:370px;"><img src="exam.png" width="25" heigth="25"></a></li>
                  <li><a href="index.php" style="margin:0px;" title="LOGOUT"><img src="log.png" width="30" height="25"></a></li>
              </ul>
           </div>
       </div>
    </nav>
    <div class="container" style="padding:50px;height:100%;box-shadow:0px 0px 6px black;">
        <div class="bg-info" style="padding-top:50px; box-shadow:0px 50px 0px violet;">
           <h1 style="text-align:center;text-shadow:3px 3px 4px rgba(0,0,0,0.7);">LISTE DE TOUS LES QCM INSCRITS <br> DANS LA BASE DE DONNEE</h1><br>
        </div><br>
        <div style="padding:50px;box-shadow:0px 0px 5px blue;" class="bg-danger">
           
           <a href="ajouterQCM.php" class="btn btn-success btn-sm"><img src="add.png" with="25" height="25"> AJOUTER</a><br><br>
           
           <table class="table1">
                <tr class="tr" >
                    <div class="container">
                       <th>N°QUEST</th>
                       <th>QUEST</th>
                       <th>ANS1</th>
                       <th>ANS2</th>
                       <th>ANS3</th>
                       <th>ANS4</th>
                       <th>Edit</th>
                       <th>DELETE</th>
                    </div>
                </tr>
                <?php
                include_once ('connexion.php');
                $sql="SELECT * FROM QCM ORDER BY NUM_QUEST asc";
                $req=mysqli_query($conn,$sql);
                if(mysqli_num_rows($req) == 0){
                    echo " Aucun quéstion à multiple choix n'est ajouté";
                }
                else{
                    while($row=mysqli_fetch_assoc($req)){
                ?>
                <div class="container" style="">
                <tr >
                    <td> <?= $row['NUM_QUEST'] ?></td>
                    <td ><?= $row['QUESTION'] ?></td>
                    <td ><?= $row['REPONSE1'] ?></td>
                    <td ><?= $row['REPONSE2'] ?></td>
                    <td ><?= $row['REPONSE3'] ?></td>
                    <td ><?= $row['REPONSE4'] ?></td>
                    <td><a href="modifierQCM.php?id=<?= $row['id']?>"><img src="modify.png" width="25px" heigth="25px"></a></td>
                    <td><a href="supprimerQCM.php?id=<?= $row['NUM_QUEST']?>"><img src="delete.png" width="25px" heigth="25px"></a></td>
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