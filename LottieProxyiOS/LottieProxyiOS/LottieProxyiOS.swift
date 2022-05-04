//
//  LottieProxyiOS.swift
//  LottieProxyiOS
//
//  Created by Csaba Huszar on 2022. 05. 03..
//

import Foundation
import UIKit
import Lottie

@objc(LottieAnimationViewWrapper)
public class LottieAnimationViewWrapper: NSObject {
    
    private let animationView = AnimationView()
    
    @objc
    public func initAnimation() {
        animationView.loopMode = .loop
        animationView.contentMode = .scaleAspectFit
    }

    @objc
    public func setAnimation(animation: String) {
        animationView.animation = Animation.named(animation)
        animationView.play { (finished) in
          /// Animation finished
        }
    }
    
    @objc
    public func getView() -> UIView {
        return animationView;
    }
}
