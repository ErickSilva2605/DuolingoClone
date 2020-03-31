using CoreAnimation;
using CoreGraphics;
using System;
using UIKit;

namespace DuolingoClone.iOS.Controls
{
    public class CircularProgressBarIOS : UIView
    {
        private CAShapeLayer _progressLayer = new CAShapeLayer();
        private CAShapeLayer _trackLayer = new CAShapeLayer();

        public CircularProgressBarIOS(double width, double height, CGColor trackColor, CGColor progressColor, double progress)
        {
            MakeCircularPath((nfloat)width, (nfloat)height, trackColor, progressColor, (nfloat)progress);
        }

        private void MakeCircularPath(nfloat width, nfloat height, CGColor trackColor, CGColor progressColor, nfloat progress)
        {
            BackgroundColor = UIColor.Clear;
            Layer.CornerRadius = (width / 2);

            var circlePath = new UIBezierPath();
            circlePath.AddArc(
                center: new CGPoint((width / 2), (height / 2)),
                radius: (nfloat)((width - 1.5) / 2),
                startAngle: (nfloat)(-0.5 * Math.PI),
                endAngle: (nfloat)(1.5 * Math.PI),
                clockWise: true
            );

            _trackLayer.Path = circlePath.CGPath;
            _trackLayer.FillColor = UIColor.Clear.CGColor;
            _trackLayer.StrokeColor = trackColor;
            _trackLayer.LineWidth = (nfloat)8.0;
            _trackLayer.StrokeEnd = (nfloat)1.0;

            Layer.AddSublayer(_trackLayer);

            _progressLayer.Path = circlePath.CGPath;
            _progressLayer.FillColor = UIColor.Clear.CGColor;
            _progressLayer.StrokeColor = progressColor;
            _progressLayer.LineWidth = (nfloat)8.0;
            _progressLayer.StrokeEnd = progress;

            Layer.AddSublayer(_progressLayer);
        }
    }
}