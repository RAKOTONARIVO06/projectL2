<div v-if="showModal">
   <label for="name">Enter name:</label><input type="text" v-model="full.name"><br>
   <label for="firstname">Enter first name</label><input type="text" v-model="full.firstName">
   <button type="submit"@click="showModal=false;saveMember();">save</button>
</div>