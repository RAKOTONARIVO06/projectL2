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
  <div id="form1" class="container">

      <div class=" container">
        <div  style="margin-top: 50px;">
            <form class="d-flex" role="search" style="max-width:80% ;">
                <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
                <button class="btn btn-outline-success" type="submit">Search</button>
            </form>
        </div>
      </div>
      
      
      <div class="alert alert-success text-center" style="max-width:90%;" v-if="successMessage">
          <button type="button" class="bg bg-success" style="float:right;border:none;border-radius:5px;width:30px;" class="close" @click="clearMessage();"><span aria-hidden="true" style="color: white;width:25px;">&times;</span></button>
          <span class="glyphicon glyphicon-alert"></span>{{successMessage}}
        </div>
      <div class="container">
        <div class="alert alert-danger text-center" style="max-width:90%;" v-if="errorMessage">
          <button type="button" class="bg bg-danger" style="float:right;border:none;border-radius:5px;width:30px;" class="close" @click="clearMessage();"><span aria-hidden="true" style="color: white;width:25px;">&times;</span></button>
          <span class="glyphicon glyphicon-alert"></span>{{errorMessage}}
        </div>
        
        <div class="card text-bg-default mb-3" style="max-width: 90%">
        
            <div class="card-header" style="height: 70px;">
              <button type="button" style="float: right;margin-top:7px;"  class="btn btn-outline-primary" @click="showAddModal = true;clearMessage();">+ Add</button>
              <h5 style="margin-top:12px;">Géstion bancaire</h5>
            </div>

            <div  class="card-body">
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
                    <div class="container" style="">
                        <tr v-for="member in members">
                            <div class="container">
                              <th scope="row"><button type="button" @click="showDeleteModal=true;clearMessage();selectMember(member);" class="btn btn-outline-danger"
                              style="
                              --bs-btn-font-size:15px;">Delete
                              </button>
                              <button type="button" class="btn btn-outline-success" @click="showUpdateModal=true;clearMessage();selectMember(member);"
                              style=" --bs-btn-font-size: 15px;" name="modifier">Update
                              </button>
                            
                              </th>
                              <td scope="col">{{member.nomClient}}</td>
                              <td scope="col">{{member.nomBanque}}</td>
                              <td scope="col">{{member.montant}}</td>
                              <td scope="col">{{member.datePret}}</td>
                              <td scope="col">{{ parseFloat(member.montant) * (1 + parseFloat(member.tauxDePret))}} </td>
                           </div>
                        </tr>
                    </div>
                    </tbody>
                </table>
                
          </div>
        </div>
        <?php include('modal.php');?>
    </div>
    
  </div>
       <script src="js/vue.min.js"></script>
       <script src="js/axios.min.js"></script>
       <script src="script.js"></script>
</body>
</html>


