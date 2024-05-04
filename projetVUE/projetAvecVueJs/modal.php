<div class="myModal"   v-if="showAddModal">
<div class="modalContainer" style="border-radius:60px;">
<div class="card border-succes mb-3" style="padding:20px;">
   
    <div class="card-header bg-transparent border-succes">
        <button type="button" @click="showAddModal=false" class="btn-close" aria-label="Close" style="float:right; background-color: red;" ></button>
        <h5>Veuillez Remplir la formulaire</h5>
    </div>
   
    <div class="card-body text-success">
        <form class="row g-3 needs-validation" method="POST" action="">
            <div class="col-md-4">
                <label for="validationCustom01" class="form-label">n*compte</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" >@number</span>
                    <input type="text" class="form-control" v-model="newMember.number"  name="number"   aria-describedby="inputGroupPrepend"  placeholder="ex:1234556"  required>
                </div>
            </div>
                
            <div class="col-md-4">
                <label for="validationCustom02" class="form-label">Nom du Client</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@name</span>
                    <input type="text" class="form-control" v-model="newMember.clientName" id="validationCustomUsername" name="name" aria-describedby="inputGroupPrepend" placeholder="Nom complet" required>
                </div>
            </div>
            <div class="col-md-4">
                <label for="validationCustomUsername" class="form-label">nom_du_banque</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@</span>
                    <input type="text" class="form-control" v-model="newMember.bancName" id="validationCustomUsername" name="banque" aria-describedby="inputGroupPrepend"  required>
                </div>
            </div>
            
        
            <div class="col-md-6">
                <label for="validationCustom03" class="form-label">Montant</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@$</span>
                    <input type="text" class="form-control" v-model="newMember.price" id="validationCustomUsername" name="montant" aria-describedby="inputGroupPrepend" required>
                    <span class="input-group-text"  id="inputGroupPrepend">.00 Ariary</span>
                </div>
            </div>
            <div class="col-md-3">
                <label for="validationCustom04" class="form-label">Date du prêt</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@Date</span>
                    <input type="text" class="form-control"  id="validationCustom03" name="date" disabled>
                </div>
            </div>
            <div class="col-md-3">
                <label for="validationCustom05" class="form-label">Taux du prêt</label>
                <div class="input-group has-validation">
                    <input type="text" class="form-control" v-model="newMember.taux" id="validationCustom05" name="taux" placeholder="taux du prêt" required >
                    <span class="input-group-text"  id="inputGroupPrepend">%</span>
                </div>
            </div>
            <div class="card-footer bg-transparent border-succes">
                <div class="col-12">
                    <button class="btn btn-primary"  type="submit" @click="saveMember();showAddModal=false;" style="float:right; margin-right: 50px;margin-top:20px;" name="button"> Valider</button>
                    <button class="btn btn-danger" @click="showAddModal=false"  style="float: right; margin-right: 10px;margin-top:20px;"> Annuler</button>
                </div>
            </div>
        </form>
    </div>
</div>
</div>
</div>

<div class="myModal" v-else-if="showDeleteModal">
    <div class="modalContainer" style="width:300px;border-radius:10px;">
        <div class="card border-succes mb-3 bg bg-default">
           <div class="card-header bg-transparent border-default">
               <h5 style="text-align:center;">Confirmation.............</h5>
           </div>
           <div class="card-body text-success">
               <p>Are you sur to delete: </p>      
              <span style="font-weight:bold;">{{clickedMember.nomClient}} </span> in this dashboard?
           </div>
           <div class="card-footer bg-transparent border-default">
                <button @click="showDeleteModal=false" style="float:right;border:none;margin-right:20px;color:white;border-radius:10px;" class="bg bg-danger">No</button>
                <button @click="showDeleteModal=false;deleteMember();" style="float:right;border:none;margin-right:15px;color:white;border-radius:10px;" class="bg bg-primary">Yes</button>
           </div>
        </div>
    </div>
</div>

<div class="myModal"   v-else-if="showUpdateModal">
<div class="modalContainer" style="border-radius:60px;">
<div class="card border-succes mb-3" style="padding:20px;">
   
    <div class="card-header bg-transparent border-succes">
        <button type="button" @click="showUpdateModal=false" class="btn-close" aria-label="Close" style="float:right; background-color: red;" ></button>
        <h5>Veuillez modifier la formulaire</h5>
    </div>
   
    <div class="card-body text-success">
        <form class="row g-3 needs-validation" method="POST" action="">
            <div class="col-md-4">
                <label for="validationCustom01" class="form-label">n*compte</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" >@number</span>
                    <input type="text" class="form-control" v-model="clickedMember.numCompte"  name="number"   aria-describedby="inputGroupPrepend"  placeholder="ex:1234556"  disabled>
                </div>
            </div>
                
            <div class="col-md-4">
                <label for="validationCustom02" class="form-label">Nom du Client</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@name</span>
                    <input type="text" class="form-control" v-model="clickedMember.nomClient" id="validationCustomUsername" name="name" aria-describedby="inputGroupPrepend" placeholder="Nom complet" required>
                </div>
            </div>
            <div class="col-md-4">
                <label for="validationCustomUsername" class="form-label">nom_du_banque</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@</span>
                    <input type="text" class="form-control" v-model="clickedMember.nomBanque" id="validationCustomUsername" name="banque" aria-describedby="inputGroupPrepend"  required>
                </div>
            </div>
            
        
            <div class="col-md-6">
                <label for="validationCustom03" class="form-label">Montant</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@$</span>
                    <input type="text" class="form-control" v-model="clickedMember.montant" id="validationCustomUsername" name="montant" aria-describedby="inputGroupPrepend" required>
                    <span class="input-group-text"  id="inputGroupPrepend">.00 Ariary</span>
                </div>
            </div>
            <div class="col-md-3">
                <label for="validationCustom04" class="form-label">Date du prêt</label>
                <div class="input-group has-validation">
                    <span class="input-group-text" id="inputGroupPrepend">@Date</span>
                    <input type="text" class="form-control"  id="validationCustom03" name="date" disabled>
                </div>
            </div>
            <div class="col-md-3">
                <label for="validationCustom05" class="form-label">Taux du prêt</label>
                <div class="input-group has-validation">
                    <input type="text" class="form-control" v-model="clickedMember.tauxDePret" id="validationCustom05" name="taux" placeholder="taux du prêt" required >
                    <span class="input-group-text"  id="inputGroupPrepend">%</span>
                </div>
            </div>
            <div class="card-footer bg-transparent border-succes">
                <div class="col-12">
                    <button class="btn btn-primary"  type="submit" @click="updateMember();showUpdateModal=false;" style="float:right; margin-right: 50px;margin-top:20px;" name="button"> Save</button>
                    <button class="btn btn-danger" @click="showUpdateModal=false"  style="float: right; margin-right: 10px;margin-top:20px;"> Annuler</button>
                </div>
            </div>
        </form>
    </div>
</div>
</div>
</div>