<?php
$servername = "localhost";
$username = "root";
$password = "narivo2777";
$database = "gestionbancaire";

$conn = mysqli_connect($servername, $username, $password, $database);

if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$crud = 'read';
$out = array('error' => false);

if (isset($_GET['crud'])) {
    $crud = $_GET['crud'];
}

if ($crud == 'read') {
    $sql = "SELECT * FROM pret";
    $query = mysqli_query($conn, $sql);
    $members = array();
    
    while ($row = mysqli_fetch_assoc($query)) {
        
        array_push($members, $row);
    }
    
    $out['members'] = $members;
}

if ($crud == 'create') {
    $num=$_POST['number'];
    $name=$_POST['clientName'];
    $banque=$_POST['bancName'];
    $prix=$_POST['price'];
    $taux=$_POST['taux'];
    $sql="INSERT INTO pret VALUES($num,'$name','$banque',$prix,CURRENT_DATE,$taux)";
    $query = mysqli_query($conn, $sql);
    if($query){
        $out['message'] = "Member added successfully";
    }
    else {
        $out['error']=true;
        $out['message'] = "Could not add Member";
    }
    
 }
 if($crud == 'update') {
    $num=$_POST['numCompte'];
    $nom=$_POST['nomClient'];
    $banque=$_POST['nomBanque'];
    $montant=$_POST['montant'];
    $taux=$_POST['tauxDePret'];
    if(isset($num) && isset($nom) && isset($banque) && isset($montant) && isset($taux)){
        $sql="UPDATE pret SET nomClient='$nom',nomBanque='$banque',montant=$montant,datePret=CURRENT_DATE,tauxDePret=$taux WHERE numCompte=$num";
        $query = mysqli_query($conn, $sql);
        if($query){
            $out['message'] = "Member updated successfully";
        }
            else{
                $out['error']=true;
                $out['message'] = "Could not update Member";
            }
        }
        else{
        $out['error']=true;
        $out['message'] = "Could not update Member";
        }
    }
   

 if ($crud == 'delete') {
    $num=$_POST['numCompte'];
   
    $sql="DELETE FROM pret WHERE numCompte='$num'";
    $query = mysqli_query($conn, $sql);
    if($query){
        $out['message'] = "Member deleted successfully";
    }
    else {
        $out['error']=true;
        $out['message'] = "Could not delete Member";
    }
    
 }
 
    


// Output the result as JSON
echo json_encode($out);

mysqli_close($conn);
die();
?>
