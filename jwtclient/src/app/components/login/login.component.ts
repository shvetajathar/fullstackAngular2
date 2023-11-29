import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { FormBuilder,FormGroup,Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  public loginform:FormGroup
  type:string='password'
  isText:boolean=false

  constructor(private fb:FormBuilder,private auth:AuthService,private router:Router) { }

  ngOnInit() {
    this.loginform=this.fb.group({
      username:['',Validators.required],
      password:['',Validators.required]

    })
  }

}
