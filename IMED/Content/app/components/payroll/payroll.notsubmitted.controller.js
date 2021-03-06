import GridLayoutControllerBase from '../../common/gridLayout/gridLayout.controller.base';

class PayrollNotSubmittedController extends GridLayoutControllerBase {
    constructor(payrollService, $rootScope) {
        'ngInject';

        super($rootScope);
        this.serverRequest = payrollService.getNotSubmittedPayroll;
    }
}

export default PayrollNotSubmittedController;