import { Component, OnInit } from '@angular/core';
import { Idetails } from '../model/idetails';
import { MovieserviceService } from '../services/movieservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-createdetails',
  templateUrl: './createdetails.component.html',
  styleUrls: ['./createdetails.component.css']
})
export class CreatedetailsComponent implements OnInit {
  detailsdata:Idetails={detailid:0,actor:'',movieid:0,gender:'',role:''}
  showdata:any[]=[]

  constructor(private ms:MovieserviceService,private route:Router) { }

  savedata(data:Idetails):void{
    this.detailsdata=data
    this.ms.addDetails(this.detailsdata).subscribe(
      ()=>{
        alert('Record added successfully')
        this.route.navigate(['/listmovies'])
      }
    )

  }

  ngOnInit() {
  }

}
