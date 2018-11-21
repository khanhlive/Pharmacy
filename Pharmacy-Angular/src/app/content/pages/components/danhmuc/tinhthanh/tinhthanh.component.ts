
import { NgModule,OnInit, Component, Pipe, PipeTransform, enableProdMode } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { DxDataGridModule,
         DxBulletModule,
         DxTemplateModule } from 'devextreme-angular';
import DataSource from 'devextreme/data/data_source';
import { TinhThanhService } from '../../../../../core/services/danhmuc/tinhthanh.service';
@Component({
  selector: 'm-tinhthanh',
  templateUrl: './tinhthanh.component.html',
  styleUrls: ['./tinhthanh.component.scss']
})
export class TinhthanhComponent implements OnInit {

  constructor(service: TinhThanhService) {
    this.dataSource = service.getDataSource();
    console.log(this.dataSource);
}
  helloWorld() {
    alert('Hello world!');
  }
  ngOnInit() {
  }
  dataSource: DataSource;
  collapsed = false;
  contentReady = (e) => {
      if(!this.collapsed) {
          this.collapsed = true;
          e.component.expandRow(["EnviroCare"]);
      }
  };
  customizeTooltip = (pointsInfo) => {
      return { text: parseInt(pointsInfo.originalValue) + "%" };
  }
}
