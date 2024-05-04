<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="note.css">
    <link rel="stylesheet" href="bootstrap.min.css">
    <script src="bootstrap.min.js"></script> 
    <script src="script.js"></script>
    <title>Document</title>
</head>
<body style="background-color:#99;padding:0px;margin:0px;">
    <?php
    include("connexion.php");
    ?>
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

    <div style="margin-top:120px;">
      <center><h2 >Classement des étudiants</h2></center>
    </div>
    <div class="container" style="margin-top:20px;padding:50px;">
    <center><table style="width:800px;">
        <div class="container">
        <tr style="height:70px;background-color:black;color:white;">
            <div class="container">
                <th><p style="text-align:center;font-size:20px;">Rang</p></th>
            </div>
            <div class="container">
                <th><p style="text-align:center;font-size:20px;">N°matt</p></th>
            </div>
            <div class="container">
                <th><p style="text-align:center;font-size:20px;">Nom</p></th>
            </div>
            <div class="container">
                <th><p style="text-align:center;font-size:20px;">Prénom</p></th>
            </div>
            <div class="container">
                <th><p style="text-align:center;font-size:20px;">Niveau</p></th>
            </div>
            <div class="container">
                <th><p style="text-align:center;font-size:20px">Note</p></th>
            </div>
        </tr>
        </div>
        <?php
         $sql="SELECT etudiant.NUM_ETUDIANT,NOM,PRENOM,NIVEAU,NOTE FROM etudiant,examen WHERE etudiant.NUM_ETUDIANT=examen.NUM_ETUDIANT ORDER BY NOTE DESC";
         $req=mysqli_query($conn,$sql);
         if(mysqli_num_rows($req) != 0){
             $rang=1;
             $i=1;
             $note=[];
             while($ligne=mysqli_fetch_assoc($req)){
                 $note[$i] = $ligne['NOTE'];
        ?>
        <tr style="height:50px;">
            <td><p style="text-align:center;font-size:15px;"><?php
            if($i==1){
                echo $rang;?><sup>er(e)</sup>
            <?php
            }else{
                if($note[$i] != $note[$i - 1]){
                    $rang=$i;
                    echo $rang;
                }
                else{
                    $rang=$rang;
                    echo $rang;
                }
                ?><sup>ème</sup>
            <?php
            }
            ?></p></td>
            <td><p style="text-align:center;font-size:15px;"><?= $ligne['NUM_ETUDIANT'] ?></p></td>
            <td><p style="text-align:center;font-size:15px;"><?= $ligne['NOM'] ?></p></td>
            <td><p style="text-align:center;font-size:15px;"><?= $ligne['PRENOM'] ?></p></td>
            <td><p style="text-align:center;font-size:15px;"><?= $ligne['NIVEAU'] ?></p></td>
            <td><p style="text-align:center;font-size:15px;"><?= $ligne['NOTE'] ?></p></td>
        </tr>
        <?php
              $i++;
             }
         }
        ?>
    </table><br>
    <a href="listeMarks.php" style="font-size:15px;">retour</a>
    </center> 
    </div> 
