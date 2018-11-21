import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DanhmucComponent } from './danhmuc.component';
import { TinhthanhComponent } from './tinhthanh/tinhthanh.component';
import { RouterModule, Routes } from '@angular/router';
import { DxButtonModule, DxDataGridModule, DxTemplateModule, DxBulletModule } from 'devextreme-angular'
import { TinhThanhService } from '../../../../core/services/danhmuc/tinhthanh.service';
const routes: Routes = [
  {
    path: '',
    component: DanhmucComponent,
    children: [
      {
        path: 'tinhthanh',
        component: TinhthanhComponent
      }
    ]
  }
]

@NgModule({
  imports: [
    CommonModule, DxButtonModule,DxDataGridModule,
    DxTemplateModule,
    DxBulletModule,
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule],
  declarations: [DanhmucComponent, TinhthanhComponent],
  providers:[TinhThanhService]
})
export class DanhmucModule { }
