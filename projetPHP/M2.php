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
<body style="background-color:grey;">
    <?php 
        include_once("connexion.php");
        $sql1= "SELECT * from etudiant WHERE niveau='M2'";
        $sql2 = "SELECT count(NUM_ETUDIANT) AS total FROM etudiant  WHERE niveau='M2'";
        $req1= mysqli_query($conn,$sql1);
        $req2= mysqli_query($conn,$sql2);
        if($req2){
            $row=mysqli_fetch_assoc($req2);
            $message = $row['total'];
        }
        else{
            $message="Pas d'étudiant";
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
    <div class="container" style="margin-top:150px;">
        <div class="form-group">
           <h3>LISTES DES ETUDIANTS EN M2:<?php echo $message;?> étudiant(s)</h3> 
        </div><br>
        <div class="form-group">
                <table class="table1">
                    <tr class="tr">
                        <div class="container">
                            <th> Num_matt</th>
                            <th>Nom</th>
                            <th>Prénom</th>
                            <th>Email</th>
                        </div>
                    </tr>
                    <?php
                    if(mysqli_num_rows($req1)==0){
                    $error="Aucun étudiant";
                    }
                    else{
                    while($row=mysqli_fetch_assoc($req1)){
                    ?>
                    <tr class="tr">
                        <div class="container">
                            <?php if (isset($error)) echo $error; ?>
                            <td><?= $row['NUM_ETUDIANT']?></td>
                            <td><?= $row['NOM']?></td>
                            <td><?= $row['PRENOM']?></td>
                            <td><?= $row['A_EMAIL']?></td>
                        </div>
                    </tr>
                    <?php
                }
            }
            ?>
            </table>
        </div>
    </div>
</body>
</html>