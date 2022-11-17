let form = document.querySelector('form');
let emailregex = /(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])/;
document.querySelector('#Send').addEventListener('click', async ()=>{
    if (form.email.value.match(emailregex)==null){
        document.querySelector('.alert').innerHTML="Hibás e-mail cím!";
        document.querySelector('.alert').classList.remove('d-none');
        document.querySelector('.alert').classList.add('alert-danger');
    }
    else if (form.name.value==""||form.message.value==""){
        document.querySelector('.alert').innerHTML="Az adatok nem lehetnek üresek!";
        document.querySelector('.alert').classList.remove('d-none');
        document.querySelector('.alert').classList.add('alert-danger');
    }
    else{
        let formdata = `name=${form.name.value}&email=${form.email.value}&message=${form.message.value}`;
        await fetch('http://localhost:8080/api/new-ticket', {method:'POST', headers:{"Content-Type": "application/x-www-form-urlencoded"}, body:formdata}).then(r=>{
            if (r.status==200) {
                document.querySelector('.alert').innerHTML="Sikeres üzenetküldés!";
                document.querySelector('.alert').classList.remove('d-none');
                document.querySelector('.alert').classList.add('alert-success');
                form.querySelectorAll('input').forEach(e=>{e.disabled = true});
                form.querySelectorAll('textarea').forEach(e=>e.disabled = true);
            }

        })
    }


})