<?php
$servername = "localhost";
$username = "root";
$password = "narivo2777";
$database = "test";

$conn = mysqli_connect($servername, $username, $password, $database);

if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}


$out = array('error' => false);

if ($crud == 'create') {
    $firstName=$_POST['firstName'];
    $name=$_POST['name'];
  
    $sql="INSERT INTO info VALUES(NULL,'$name','$firstName')";
    $query = mysqli_query($conn, $sql);
    if($query){
        $out['message'] = "Member added successfully";
    }
    else {
        $out['error']=true;
        $out['message'] = "Could not add Member";
    }
    
 }


// Output the result as JSON
echo json_encode($out);

mysqli_close($conn);
?>
