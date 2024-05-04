<?php 
        include_once("connexion.php");
        $sql1= "SELECT * from etudiant WHERE niveau='L3'";
        $sql2 = "SELECT count(NUM_ETUDIANT) AS total FROM etudiant  WHERE niveau='L3'";
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
      <div class="container" style="margin-top:100px;">
        <div class="form-group">
           <h3 style="background-color: blue; width:500px;padding:25px;color:white;">Listes des étudiants en L3 : <?php echo $message;?> étudiant(s)</h3> 
        </div>
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