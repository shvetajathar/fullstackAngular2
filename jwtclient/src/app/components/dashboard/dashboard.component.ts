import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/services/api.service';
import { AuthService } from 'src/app/services/auth.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private api:ApiService,private auth:AuthService) { }
  users:any=[]

  ngOnInit() {
    this.api.getUsers().subscribe(data=>{
      this.users=data
    })
  }

}
