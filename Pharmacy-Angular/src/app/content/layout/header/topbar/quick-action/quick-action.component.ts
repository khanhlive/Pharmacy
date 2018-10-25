import { Component, OnInit, HostBinding, ChangeDetectionStrategy } from '@angular/core';

@Component({
	selector: 'm-quick-action',
	templateUrl: './quick-action.component.html',
	changeDetection: ChangeDetectionStrategy.OnPush
})
export class QuickActionComponent implements OnInit {
	@HostBinding('class')
	// tslint:disable-next-line:max-line-length
	classes = 'dropdown dropdown-extended dropdown-tasks';

	@HostBinding('attr.m-dropdown-toggle') attrDropdownToggle = 'click';

	constructor() {}

	ngOnInit(): void {}
}
