var app = new Vue({
    el:'#tay',
    data:{
    showModal:false,
    full:{name:'',firstName:''},
   },
   methods:{
        saveMember(){
            var memForm = app.toFormData(app.full);
            axios.post('apis.php?crud=create',memForm)
            .then(function (response) {
            app.full = {name:'',firstName:''};
            if(response.data.error){
                app.errorMessage=response.data.message;
            }
            else{
                app.successMessage=response.data.message;
            }
          
            
            });
        },
        toFormData(obj){
            var form_data = new FormData();
            for(var key in obj){
                FormData.append(key,obj[key]);
            }
            return form_data;
        }   
   }
   });