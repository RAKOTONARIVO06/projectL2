var app=new Vue({
    el:"#form1",
    data:{
       showAddModal: false,
       showDeleteModal:false,
       showUpdateModal:false,
       members: [],
       newMember:{number:'',clientName:'',bancName:'',price:'',taux:''},
       successMessage:'',
       errorMessage:'',
       clickedMember:{},
    },
    
    mounted(){
       this.getAllMembers();
   },
    methods:{
        getAllMembers(){
            axios.get('http://127.0.0.1:8000/api/show')
            .then(function (response) {
            console.log(response.data);
            if(response.data.error){
                app.errorMessage=response.data.message;
            }
            else{
                app.members=response.data.members;
            }
        });
        },

        saveMember(){
           
            var memForm=app.toFormData(app.newMember);
            axios.post('api.php?crud=create',memForm)
            .then(function(response){
            app.newMember = {number:'',clientName:'',bancName:'',price:'',taux:''};
            if(response.data.error){
                app.errorMessage=response.data.message;
            }
            else{
                app.successMessage=response.data.message;
                app.getAllMembers();
            }
          
            
            });
            
        },
        
        selectMember(member){
          app.clickedMember=member;
        },
        deleteMember(){
            var memForm=app.toFormData(app.clickedMember);
            axios.post('api.php?crud=delete',memForm)
            .then(function(response){
            app.clickedMember = {};
            if(response.data.error){
                app.errorMessage=response.data.message;
            }
            else{
                app.successMessage=response.data.message;
                app.getAllMembers();
            }
          
            
            });
        },
        updateMember(){
            var memForm=app.toFormData(app.clickedMember);
            axios.post('api.php?crud=update',memForm)
            .then(function(response){
            app.clickedMember = {};
            if(response.data.error){
                app.errorMessage=response.data.message;
            }
            else{
                app.successMessage=response.data.message;
                app.getAllMembers();
            }
          
            
            });
        },
        clearMessage(){
            app.successMessage='';
            app.errorMessage='';
        },
       
        toFormData(obj){
            var form_data = new FormData();
            for(var key in obj){
                form_data.append(key,obj[key]);
            }
            return form_data;
        }
       
    }
    
});