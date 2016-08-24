import MediaAwareControllerBase from '../../common/mediaQuery/MediaAwareControllerBase';

class DashboardController extends MediaAwareControllerBase {
    constructor(mediaQueryFactory) {
        'ngInject';
        super(mediaQueryFactory);

        this.name = 'dashboard';
    }
}

export default DashboardController;