import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExercisesComponent } from './exercises/exercises.component';
import { HistoryComponent } from './history/history.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { WorkoutsComponent } from './workouts/workouts.component';

const routes: Routes = [
{path:'', component: HomeComponent},
{path:'register', component: RegisterComponent},
{path:'exercises', component: ExercisesComponent},
{path:'workouts', component: WorkoutsComponent},
{path:'history', component: HistoryComponent},
{path:'**', component: HistoryComponent, pathMatch: 'full'}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
