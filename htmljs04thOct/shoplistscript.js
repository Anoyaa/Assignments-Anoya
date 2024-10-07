                                          
function addItem()
{
const iteminput=document.getElementById('newitem');
const itemlist=document.getElementById('itemlist');                                                
const itemText=iteminput.value.trim();
const li=document.createElement('li');
li.textContent=itemText;
const deleteButton=document.createElement('button');
deleteButton.textContent='delete';
deleteButton.onclick=()=>li.remove();
li.appendChild(deleteButton);
itemlist.appendChild(li);

iteminput.value='';
iteminput.focus();
}