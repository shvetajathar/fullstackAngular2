import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { FormGroup,FormControl,Validator } from '@angular/forms';
@Component({
  selector: 'app-emp',
  templateUrl: './emp.component.html',
  styleUrls: ['./emp.component.css']
})
export class EmpComponent implements OnInit {
  

  constructor(private formBuilder:FormBuilder) { }
  empform=this.formBuilder.group({
    name:['',Validators.required,Validators.maxLength(30)],
    email:['',Validators.email],
    city:['',Validators.pattern("[a-zA-z]")],
    
  })
  Save(){
    console.log(this.empform.value)
  }
  // empform=this.formBuilder.group({
  //   firstname:[''],
  //   age:[''],
  //   address:this.formBuilder.group({
  //     Line1:[''],
  //     City:[''],
  //     State:['']
  //   })
  // })


  ngOnInit() {
  }


}
