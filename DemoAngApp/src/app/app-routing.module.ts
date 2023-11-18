import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MovieService } from './movieservice/movie.service';


const routes: Routes = [
  {path:'listmovies',component:MovieService}
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
