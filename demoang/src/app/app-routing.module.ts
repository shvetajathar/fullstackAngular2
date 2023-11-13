import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DemoComponent } from './demo/demo.component';
import { EmpComponent } from './emp/emp.component';
import { RegisterComponent } from './register/register.component';
import { SimpleComponent } from './simple/simple.component';

const routes: Routes = [
  {path:'demo',component:DemoComponent},
  {path:'emp',component:EmpComponent},
  {path:'register',component:RegisterComponent},
  {path:'simple',component:SimpleComponent}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
