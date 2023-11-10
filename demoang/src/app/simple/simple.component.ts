import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-simple',
  templateUrl: './simple.component.html',
  styleUrls: ['./simple.component.css']
})
export class SimpleComponent implements OnInit {
  weekdays:string[]=['sunday','monday','tuesday','wednesday','thursday','friday','saturday']
  age:number=26
  emp:Employee={id:123,name:'Tom',salary:40000,city:'Mumbai'}
  emplist:Employee[]=[
    {id:123,name:'Tom',salary:40000,city:'Mumbai'},
    {id:124,name:'raj',salary:70000,city:'Pune'},
    {id:125,name:'Bob',salary:90000,city:'Chennai'},
    {id:126,name:'Jay',salary:60000,city:'Delhi'},
    {id:127,name:'Ali',salary:80000,city:'Banglore'}

  ]
  GetTotal():number{
    var total:number=0;
    for(var i=0;i<this.emplist.length;i++)
    {
      total=total+this.emplist[i].salary

    }
    return total
  }
  todaydate:number=Date.now();
  constructor(private msgservice:MessageService) { 
  }
  msg=this.msgservice.DisplayService("Tom")

  ngOnInit() {
  }

}
