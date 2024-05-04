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
<body style="background-color:rgba(0,0,0,0.9);">  
       
        <div class=" col-md-6">
        <?php   
            include("M2snvb.php");
        ?>
        </div>
        <div  class="  col-md-6">
        <?php   
            include("M1snvb.php");
        ?>
        </div>
    
    
        <center><div  class=" col-md-12" style="margin-top:-70px;">
         <?php   
            include("L3snvb.php");
        ?>
        </div></center>
        <div  class=" col-md-6" style="margin-top:-70px;">
        <?php   
            include("L2snvb.php");
        ?>
        </div>
    
        <div  class="  col-md-6" style="margin-top:-70px;">
        <?php   
            include("L1snvb.php");
        ?>
        </div>
    </div>
</body>
</html>