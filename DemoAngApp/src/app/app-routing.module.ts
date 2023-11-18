import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MovieService } from './movieservice/movie.service';
import { AddmovieComponent } from './addmovie/addmovie.component';
import { ListmoviesComponent } from './listmovies/listmovies.component';


const routes: Routes = [
  {path:'listmovies',component:ListmoviesComponent},
  {path:'add',component:AddmovieComponent}

 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
