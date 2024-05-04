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
    include ("connexion.php");
    $sql="SELECT * FROM EXAMEN";
    $req=mysqli_query($conn,$sql);
    ?>
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
                    <li><a href="" title="LES QCM" style="margin-right:50px;"><img src="question.png" width="25" heigth="25" alt=""></a></li>
                    <li><a href="" title="PASSER A L'EXAMEN"><img src="exam.png" width="25" heigth="25"></a></li>
                </ul>
           </div>
       </div>
    </nav>
    <div style="margin-top:150px;">
      <center><h2>Liste des notes des étudiants</h2></center>
    </div>
    <div class="container" style="margin-top:20px;padding:100px;box-shadow: 0px 0px 6px blueviolet;">
    <center><table style="width:800px;">
        <tr>
            <th><p style="text-align:center;font-size:20px;">Num_examen</p></th>
            <th><p style="text-align:center;font-size:20px;">Num_etudiant</p></th>
            <th><p style="text-align:center;font-size:20px;">Anne_univ</p></th>
            <th><p style="text-align:center;font-size:20px;">Note</p></th>
        </tr>
        <?php
        if(mysqli_num_rows($req) == 0){
          $error="ça n'a pas fonctionné" ;
        }else{
          while($row=mysqli_fetch_assoc($req)){
              $NUM_EXAMEN=$row['NUM_EXAMEN'];
              $NUM_ETUDIANT=$row['NUM_ETUDIANT'];
              $ANNE_UNIV=$row['ANNE_UNIV'];
              $NOTE=$row['NOTE'];
         
        ?>

        <tr>
            <td><?=$NUM_EXAMEN ?></td>
            <td><?=$NUM_ETUDIANT?></td>
            <td><?=$ANNE_UNIV ?></td>
            <td><?=$NOTE?></td>
        </tr>
        <?php 
        }
    }
    ?>
    </table>
    </center> 
    </div>